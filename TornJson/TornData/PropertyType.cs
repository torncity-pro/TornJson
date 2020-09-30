/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2019  TornCityPro
  
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

using System.Collections.Generic;
using Newtonsoft.Json;
using TornJson.CommonData;

namespace TornJson.TornData
{
    public class PropertyType : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("happy")]
        public short Happy { get; set; }

        [JsonProperty("upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty("upgrades_available")]
        public List<string> UpgradesAvailable { get; private set; }

        [JsonProperty("staff_available")]
        public List<string> StaffAvailable { get; private set; }
    }
}
