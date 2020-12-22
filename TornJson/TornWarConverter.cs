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
using System.Collections.Generic;
using Newtonsoft.Json;
using TornJson.FactionData;

namespace TornJson
{
    public class TornWarConverter<T> : JsonConverter<List<T>> where T : War, new()
    {
        public override List<T> ReadJson(JsonReader reader, Type objectType, List<T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }
            
            if (!hasExistingValue)
            {
                existingValue = new List<T>();
            }

            if (reader.TokenType == JsonToken.StartArray)
            {
                serializer.Populate(reader, existingValue);
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                reader.Read();
            }

            return existingValue;
        }
        
        public override void WriteJson(JsonWriter writer, List<T> value, JsonSerializer serializer)
        {
            if (writer == null) throw new ArgumentNullException(nameof(writer));
            if (serializer == null) throw new ArgumentNullException(nameof(serializer));
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.Count == 0)
            {
                writer.WriteStartObject();
                writer.WriteEndObject();
            }
            else
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}