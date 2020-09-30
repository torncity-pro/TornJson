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

namespace TornJson.CommonData
{
    public class Territory : ApiListItem
    {
        [JsonProperty("sector")]
        public byte Sector { get; set; }

        [JsonProperty("size")]
        public byte Size { get; set; }

        [JsonProperty("density")]
        public byte Density { get; set; }

        [JsonProperty("daily_respect")]
        public short DailyRespect { get; set; }

        [JsonProperty("faction")]
        public int Faction { get; set; }

        [JsonProperty("coordinate_x")]
        public string CoordinateX { get; set; }

        [JsonProperty("coordinate_y")]
        public string CoordinateY { get; set; }

        [JsonProperty("neighbors")]
        public List<string> Neighbors { get; private set; }
    }
}
