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
using TornJsonData.CommonData;

namespace TornJsonData.TornData
{
    public class Results
    {
        [JsonProperty("perk")]
        public List<string> Perk { get; private set; }

        [JsonProperty("manual_labor")]
        public List<string> ManualLabor { get; private set; }

        [JsonProperty("intelligence")]
        public List<string> Intelligence { get; private set; }

        [JsonProperty("endurance")]
        public List<string> Endurance { get; private set; }
    }

    public class Education : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("money_cost")]
        public int MoneyCost { get; set; }

        [JsonProperty("tier")]
        public byte Tier { get; set; }

        [JsonProperty("duration")]
        public int DurationInSeconds { get; set; }

        public System.TimeSpan Duration => System.TimeSpan.FromSeconds(DurationInSeconds);

        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("prerequisites")]
        public List<string> Prerequisites { get; private set; }
    }
}
