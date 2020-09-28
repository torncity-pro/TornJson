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

namespace TornJsonData.Contract.TornData
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class Competition
    {
        [JsonProperty("competition")]
        public string CompetitionName { get; set; }
        
        [JsonProperty("teams")]
        public List<Team> Teams { get; private set; }
    }

    public class Team
    {
        [JsonProperty("position")]
        public byte Position { get; set; }
        
        [JsonProperty("team")]
        public string TeamCodename { get; set; }
        
        [JsonProperty("name")]
        public string TeamName { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("score")]
        public short Score { get; set; }
        
        [JsonProperty("lives")]
        public short Lives { get; set; }
        
        [JsonProperty("participants")]
        public short Participants { get; set; }
        
        [JsonProperty("wins")]
        public int Wins { get; set; }
        
        [JsonProperty("losses")]
        public int Losses { get; set; }
    }
}