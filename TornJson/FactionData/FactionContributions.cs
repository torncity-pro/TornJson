/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2021  TornCityPro
  
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
using System.Collections.Generic;
using TornJson.CommonData;

namespace TornJson.FactionData
{
    public class Contribution : IntApiListItem
    {
        [JsonProperty("contributed")]
        public long Contributed { get; set; }

        [JsonProperty("in_faction")]
        public bool InFaction { get; set; }
    }

    public class FactionContributions
    {
        [JsonProperty("AlcoholUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AlcoholUsed { get; private set; }

        [JsonProperty("AttacksDamage")] 
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksDamage { get; private set; }

        [JsonProperty("AttacksDamageHits")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksDamageHits { get; private set; }

        [JsonProperty("AttacksDamaging")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksDamaging { get; private set; }
        
        [JsonProperty("AttacksHosp")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksHosp { get; private set; }
        
        [JsonProperty("AttacksLeave")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksLeave { get; private set; }
        
        [JsonProperty("AttacksLost")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksLost { get; private set; }
        
        [JsonProperty("AttacksMug")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksMug { get; private set; }
        
        [JsonProperty("AttacksRunaway")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksRunaway { get; private set; }
        
        [JsonProperty("AttacksWon")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> AttacksWon { get; private set; }
        
        [JsonProperty("BestChain")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> BestChain { get; private set; }
        
        [JsonProperty("Busts")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Busts { get; private set; }
        
        [JsonProperty("CandyUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> CandyUsed { get; private set; }
        
        [JsonProperty("CaymanInterest")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> CaymanInterest { get; private set; }
        
        [JsonProperty("CriminalOffences")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> CriminalOffences { get; private set; }
        
        [JsonProperty("DrugOverdoses")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> DrugOverdoses { get; private set; }
        
        [JsonProperty("DrugsUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> DrugsUsed { get; private set; }
        
        [JsonProperty("EnergyDrinkUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> EnergyDrinkUsed { get; private set; }
        
        [JsonProperty("GymDefense")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> GymDefense { get; private set; }
        
        [JsonProperty("GymDexterity")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> GymDexterity { get; private set; }
        
        [JsonProperty("GymSpeed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> GymSpeed { get; private set; }
        
        [JsonProperty("GymStrength")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> GymStrength { get; private set; }
        
        [JsonProperty("GymTrains")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> GymTrains { get; private set; }
        
        [JsonProperty("Hosps")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Hosps { get; private set; }
        
        [JsonProperty("HospTimeGiven")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> HospTimeGiven { get; private set; }
        
        [JsonProperty("HospTimeReceived")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> HospTimeReceived { get; private set; }
        
        [JsonProperty("Hunting")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Hunting { get; private set; }
        
        [JsonProperty("Jails")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Jails { get; private set; }
        
        [JsonProperty("MedicalCooldownUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> MedicalCooldownUsed { get; private set; }
        
        [JsonProperty("MedicalItemRecovery")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> MedicalItemRecovery { get; private set; }
        
        [JsonProperty("MedicalItemsUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> MedicalItemsUsed { get; private set; }
        
        [JsonProperty("OrganisedCrimeFail")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> OrganisedCrimeFail { get; private set; }
        
        [JsonProperty("OrganisedCrimeMoney")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> OrganisedCrimeMoney { get; private set; }
        
        [JsonProperty("OrganisedCrimeRespect")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> OrganisedCrimeRespect { get; private set; }
        
        [JsonProperty("OrganisedCrimeSuccess")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> OrganisedCrimeSuccess { get; private set; }
        
        [JsonProperty("Rehabs")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Rehabs { get; private set; }
        
        [JsonProperty("Revives")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> Revives { get; private set; }
        
        [JsonProperty("TerritoryRespect")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> TerritoryRespect { get; private set; }
        
        [JsonProperty("TravelTime")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> TravelTime { get; private set; }
        
        [JsonProperty("TravelTimes")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        public List<Contribution> TravelTimes { get; private set; }
    }
}
