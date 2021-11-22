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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TornJson.CommonData;

namespace TornJson.KeyData
{
    public class KeyDataPropertyBag : PropertyBagBase
    {
        [JsonProperty("access_level")]
        public short AccessLevel { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("selections")]
        public Selection Permissions { get; private set; }
    }

    public class Selection
    {
        [JsonProperty("company")]
        public List<string> Company { get; private set; }

        [JsonProperty("faction")]
        public List<string> Faction { get; private set; }

        [JsonProperty("market")]
        public List<string> Market { get; private set; }

        [JsonProperty("property")]
        public List<string> Property { get; private set; }

        [JsonProperty("torn")]
        public List<string> Torn { get; private set; }

        [JsonProperty("user")]
        public List<string> User { get; private set; }

        [JsonProperty("key")]
        public List<string> Key { get; private set; }
    }
}
