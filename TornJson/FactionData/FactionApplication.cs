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
using TornJson.CommonData;

namespace TornJson.FactionData
{
    public class FactionApplication : ApiListItem
    {
        [JsonProperty("userID")] public string UserId { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("level")] public int Level { get; set; }

        [JsonProperty("stats")] public FactionApplicationStats Stats { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("expires")] public long Expiration { get; set; }
    }

    public class FactionApplicationStats
    {
        [JsonProperty("strength")] public long Strength { get; set; }

        [JsonProperty("speed")] public long Speed { get; set; }

        [JsonProperty("dexterity")] public long Dexterity { get; set; }

        [JsonProperty("defence")] public long Defence { get; set; }
    }
}