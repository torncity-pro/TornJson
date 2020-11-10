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

namespace TornJson.TornData
{
    public class TornPropertyBag : PropertyBagBase
    {
        [JsonProperty("stocks")]
        [JsonConverter(typeof(TornListConverter<Stock, int>))]
        public List<Stock> Stocks { get; private set; }

        [JsonProperty("stats")] public Stats CityStats { get; set; }

        [JsonProperty("honors")]
        [JsonConverter(typeof(TornListConverter<Honor, int>))]
        public List<Honor> Honors { get; private set; }

        [JsonProperty("medals")]
        [JsonConverter(typeof(TornListConverter<Medal, int>))]
        public List<Medal> Medals { get; private set; }

        [JsonProperty("gyms")]
        [JsonConverter(typeof(TornListConverter<Gym, int>))]
        public List<Gym> Gyms { get; private set; }

        [JsonProperty("items")]
        [JsonConverter(typeof(TornListConverter<Item, int>))]
        public List<Item> Items { get; private set; }

        [JsonProperty("education")]
        [JsonConverter(typeof(TornListConverter<Education, int>))]
        public List<Education> Educations { get; private set; }

        [JsonProperty("organisedcrimes")]
        [JsonConverter(typeof(TornListConverter<OrganizedCrime, int>))]
        public List<OrganizedCrime> OrganizedCrimes { get; private set; }

        [JsonProperty("properties")]
        [JsonConverter(typeof(TornListConverter<PropertyType, int>))]
        public List<PropertyType> Properties { get; private set; }

        [JsonProperty("companies")]
        [JsonConverter(typeof(TornListConverter<CompanyType, int>))]
        public List<CompanyType> Companies { get; private set; }

        //// TODO: Fix this to fit into new List schema
        [JsonProperty("factiontree")]
        public Dictionary<string, Dictionary<string, FactionUpgrade>> FactionUpgradeTree { get; private set; }

        [JsonProperty("territory")]
        [JsonConverter(typeof(TornListConverter<Territory, string>))]
        public List<Territory> Territories { get; private set; }

        [JsonProperty("rackets")]
        [JsonConverter(typeof(TornListConverter<Racket, string>))]
        public List<Racket> Rackets { get; private set; }

        [JsonProperty("bank")] public BankRates BankRates { get; set; }

        [JsonProperty("pawnshop")] public PawnShop PawnShop { get; set; }

        [JsonProperty("raids")]
        [JsonConverter(typeof(TornListConverter<Raid, int>))]
        public List<Raid> Raids { get; private set; }

        [JsonProperty("territorywars")]
        [JsonConverter(typeof(TornListConverter<TerritoryWar, string>))]
        public List<TerritoryWar> TerritoryWars { get; private set; }

        [JsonProperty("competition")] public Competition Competition { get; set; }
    }
}