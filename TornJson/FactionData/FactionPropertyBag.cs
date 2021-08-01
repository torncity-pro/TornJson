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

using System.Collections.Generic;
using Newtonsoft.Json;
using TornJson.CommonData;

namespace TornJson.FactionData
{
    public class FactionPropertyBag : PropertyBagBase
    {
        [JsonProperty("ID")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("tag")] public string Tag { get; set; }

        [JsonProperty("leader")] public int Leader { get; set; }

        [JsonProperty("co-leader")] public int CoLeader { get; set; }

        [JsonProperty("respect")] public int Respect { get; set; }

        [JsonProperty("age")] public int Age { get; set; }

        [JsonProperty("capacity")] public short Capacity { get; set; }

        [JsonProperty("best_chain")] public int BestChain { get; set; }

        [JsonProperty("members")]
        [JsonConverter(typeof(TornListConverter<FactionMember>))]
        public List<FactionMember> Members { get; private set; }

        [JsonProperty("territory")]
        [JsonConverter(typeof(TornListConverter<Territory>))]
        public List<Territory> Territory { get; private set; }

        [JsonProperty("chain")] public ActiveChain Chain { get; set; }

        [JsonProperty("faction_id")] public int FactionId { get; set; }

        [JsonProperty("points")] public int Points { get; set; }

        [JsonProperty("money")] public long Money { get; set; }

        [JsonProperty("weapons")] public List<LoanableArmoryItem> Weapons { get; private set; }

        [JsonProperty("armor")] public List<LoanableArmoryItem> Armor { get; private set; }

        [JsonProperty("temporary")] public List<ArmoryItem> TemporaryItems { get; private set; }

        [JsonProperty("medical")] public List<ArmoryItem> MedicalItems { get; private set; }

        [JsonProperty("drugs")] public List<ArmoryItem> Drugs { get; private set; }

        [JsonProperty("boosters")] public List<ArmoryItem> Boosters { get; private set; }

        [JsonProperty("mainnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> MainNews { get; private set; }

        [JsonProperty("attacknews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> AttackNews { get; private set; }

        [JsonProperty("fundsnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> FundsNews { get; private set; }

        [JsonProperty("armorynews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> ArmoryNews { get; private set; }

        [JsonProperty("crimesnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> CrimesNews { get; private set; }

        [JsonProperty("membershipnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> MembershipNews { get; private set; }

        [JsonProperty("crimes")]
        [JsonConverter(typeof(TornListConverter<Crime>))]
        public List<Crime> Crimes { get; private set; }

        [JsonProperty("attacks")]
        [JsonConverter(typeof(TornListConverter<AttackDetailed>))]
        public List<AttackDetailed> Attacks { get; private set; }

        [JsonProperty("revives")]
        [JsonConverter(typeof(TornListConverter<ReviveDetailed>))]
        public List<ReviveDetailed> Revives { get; private set; }

        [JsonProperty("upgrades")]
        [JsonConverter(typeof(TornListConverter<Upgrade>))]
        public List<Upgrade> Upgrades { get; private set; }

        [JsonProperty("stats")] public FactionStats Stats { get; set; }

        [JsonProperty("contributors")] public FactionContributions Contributions { get; set; }

        [JsonProperty("donations")]
        [JsonConverter(typeof(TornListConverter<UserBalance>))]
        public List<UserBalance> Donations { get; private set; }

        [JsonProperty("chains")]
        [JsonConverter(typeof(TornListConverter<Chain>))]
        public List<Chain> Chains { get; private set; }

        [JsonProperty("applications")]
        [JsonConverter(typeof(TornListConverter<FactionApplication>))]
        public List<FactionApplication> Applications { get; private set; }

        [JsonProperty("cesium")] public List<ArmoryItem> Cesium { get; private set; }

        [JsonProperty("peace")]
        public Dictionary<string, int> Peace { get; private set; }
        
        [JsonProperty("territory_wars")]
        [JsonConverter(typeof(TornWarConverter<TerritoryWar>))]
        public List<TerritoryWar> TerritoryWars { get; private set; }

        [JsonProperty("raid_wars")]
        [JsonConverter(typeof(TornWarConverter<RaidWar>))]
        public List<RaidWar> RaidWars { get; private set; }
    }
}