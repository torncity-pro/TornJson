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

namespace TornJson.CommonData
{
    public class Revive : IntApiListItem
    {
        [JsonProperty("timestamp")] public int Timestamp { get; set; }

        [JsonProperty("reviver_id")] public int ReviverId { get; set; }

        [JsonProperty("reviver_faction")] public int ReviverFaction { get; set; }

        [JsonProperty("target_id")] public int TargetId { get; set; }

        [JsonProperty("target_faction")] public int TargetFaction { get; set; }
        
        [JsonProperty("target_hospital_reason")]
        public string TargetHospitalReason { get; set; }

        [JsonProperty("target_last_action")] public LastAction TargetLastAction { get; set; }
        
        [JsonProperty("result")] public string Result { get; set; }

        [JsonProperty("chance")] public float Chance { get; set; }

        [JsonProperty("target_early_discharge")] public bool EarlyDischarge { get; set; }
    }

    public class ReviveDetailed : Revive
    {
        [JsonProperty("reviver_name")] public string ReviverName { get; set; }

        [JsonProperty("reviver_factionname")] public string ReviverFactionName { get; set; }

        [JsonProperty("target_name")] public string TargetName { get; set; }

        [JsonProperty("target_factionname")] public string TargetFactionName { get; set; }
    }
}