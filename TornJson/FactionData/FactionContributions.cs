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
        public List<Contribution> Contributors { get; private set; }

        [JsonProperty("AlcoholUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AlcoholUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksDamage")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksDamage { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksDamageHits")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksDamageHits { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksDamaging")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksDamaging { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksHosp")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksHosp { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksLeave")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksLeave { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksLost")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksLost { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksMug")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksMug { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksRunaway")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksRunaway { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("AttacksWon")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> AttacksWon { get { return Contributors; } set { Contributors = value; } }
        
        [JsonProperty("Busts")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Busts { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("CandyUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> CandyUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("CaymanInterest")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> CaymanInterest { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("CriminalOffences")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> CriminalOffences { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("DrugOverdoses")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> DrugOverdoses { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("DrugsUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> DrugsUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("EnergyDrinkUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> EnergyDrinkUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("GymDefense")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> GymDefense { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("GymDexterity")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> GymDexterity { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("GymSpeed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> GymSpeed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("GymStrength")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> GymStrength { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("GymTrains")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> GymTrains { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("Hosps")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Hosps { get { return Contributors; } set { Contributors = value; } }
        
        [JsonProperty("HospTimeGiven")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> HospTimeGiven { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("HospTimeReceived")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> HospTimeReceived { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("Hunting")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Hunting { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("Jails")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Jails { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("MedicalCooldownUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> MedicalCooldownUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("MedicalItemRecovery")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> MedicalItemRecovery { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("MedicalItemsUsed")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> MedicalItemsUsed { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("OrganisedCrimeFail")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> OrganisedCrimeFail { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("OrganisedCrimeMoney")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> OrganisedCrimeMoney { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("OrganisedCrimeRespect")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> OrganisedCrimeRespect { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("OrganisedCrimeSuccess")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> OrganisedCrimeSuccess { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("Rehabs")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Rehabs { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("Revives")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> Revives { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("TerritoryRespect")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> TerritoryRespect { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("TravelTime")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> TravelTime { get { return Contributors; } set { Contributors = value; } }

        [JsonProperty("TravelTimes")]
        [JsonConverter(typeof(TornListConverter<Contribution>))]
        private List<Contribution> TravelTimes { get { return Contributors; } set { Contributors = value; } }
    }
}
