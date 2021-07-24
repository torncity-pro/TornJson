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

namespace TornJson.FactionData
{
    public abstract class War
    {
        [JsonProperty("defending_faction")] public int DefendingFactionId { get; set; }

        [JsonProperty("start_time")] public int StartTime { get; set; }
    }

    public class RaidWar : War
    {
        [JsonProperty("raiding_faction")] public int AssaultingFactionId { get; set; }

        [JsonProperty("raider_score")] public float RaiderScore { get; set; }

        [JsonProperty("defender_score")] public float DefenderScore { get; set; }
    }

    public class TerritoryWar : War
    {
        [JsonProperty("territory")] public string Territory { get; set; }

        [JsonProperty("assaulting_faction")] public int AssaultingFactionId { get; set; }

        [JsonProperty("score")] public int Score { get; set; }

        [JsonProperty("required_score")] public int RequiredScore { get; set; }

        [JsonProperty("end_time")] public int EndTime { get; set; }
    }
}