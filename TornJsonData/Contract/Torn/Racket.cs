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

using Newtonsoft.Json;
using TornJsonData.Contract.Common;

namespace TornJsonData.Contract.Torn
{
    public class Racket : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public byte Level { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }

        [JsonProperty("created")]
        public int CreatedTimestamp { get; set; }

        public System.DateTime CreatedDateTime => System.DateTime.UnixEpoch.AddSeconds(CreatedTimestamp);

        [JsonProperty("changed")]
        public int ChangedTimestamp { get; set; }

        public System.DateTime ChangedDateTime => System.DateTime.UnixEpoch.AddSeconds(ChangedTimestamp);

        [JsonProperty("faction")]
        public int Faction { get; set; }
    }
}
