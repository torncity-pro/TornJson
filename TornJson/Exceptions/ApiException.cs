/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2020  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

using System;
using System.Runtime.Serialization;
using TornJson.CommonData;

namespace TornJson.Exceptions
{
    /// <summary>
    ///     An extension of exception specific to exceptions thrown by the Torn API
    /// </summary>
    [Serializable]
    public class ApiException : Exception
    {
        /// <summary>
        ///     Default constructor
        /// </summary>
        public ApiException()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="error">Torn API Error info object</param>
        public ApiException(TornExceptionInfo error) : base(error?.ErrorMessage ??
                                                            throw new ArgumentNullException(nameof(error)))
        {
            TornErrorInfo = error;
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public ApiException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner exception</param>
        public ApiException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Context</param>
        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        ///     Gets the error object used to construct the error
        /// </summary>
        public TornExceptionInfo TornErrorInfo { get; private set; }

        /// <summary>
        ///     Determines when a Torn Exception is retryable
        /// </summary>
        /// <returns>True if it is retryable</returns>
        public bool IsRetryable()
        {
            if (TornErrorInfo == null) return false;

            return TornErrorInfo.ErrorCode switch
            {
                5 => true,
                8 => true,
                9 => true,
                12 => true,
                14 => true,
                _ => false
            };
        }
    }
    
    public static class ApiExceptionExtensions
    {
    
        /// <summary>
        ///     Converts the API return object with error info into an exception
        /// </summary>
        /// <param name="ex">The error information from the api call</param>
        /// <returns>The concrete exception class for the specific error</returns>
        public static ApiException CreateExceptionFromExceptionInfo(this TornExceptionInfo ex)
        {
            if (ex == null) throw new ArgumentNullException(nameof(ex));

            return ex.ErrorCode switch
            {
                1 => new EmptyApiKeyException(ex),
                2 => new IncorrectApiKeyException(ex),
                3 => new WrongTypeException(ex),
                4 => new WrongFieldException(ex),
                5 => new TooManyRequestsException(ex),
                6 => new IncorrectIdException(ex),
                7 => new IncorrectIdEntityRelationException(ex),
                8 => new BlockedIpException(ex),
                9 => new ApiDisabledException(ex),
                10 => new PlayerBannedException(ex),
                11 => new ApiKeyChangeException(ex),
                12 => new ApiKeyReadException(ex),
                13 => new ApiKeyDisabledException(ex),
                14 => new DailyReadLimitReachedException(ex),
                15 => new TemporaryErrorException(ex),
                16 => new AccessLevelException(ex),
                _ => new UnknownException(ex)
            };
        }
    }
}