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

namespace TornJson.Fields
{
    /// <summary>
    ///     Meant to be inherited to specify string value constants to give to the selection field in the api
    /// </summary>
    public abstract class ApiField
    {
        /// <summary>
        ///     The string representation of the field to query
        /// </summary>
        internal readonly string fieldName;

        /// <summary>
        ///     Protected constructor for the inheriting classes to use
        /// </summary>
        /// <param name="fieldName"></param>
        protected ApiField(string fieldName)
        {
            this.fieldName = fieldName;
        }

        /// <summary>
        ///     The accessor for the fieldName
        /// </summary>
        public string FieldName => fieldName;
    }
}