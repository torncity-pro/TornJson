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

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using TornJson.CommonData;

namespace TornJson.UserData
{
    public class UserPropertyBag : PropertyBagBase
    {
        [JsonProperty("id")] public string id => PlayerId.ToString(CultureInfo.InvariantCulture);

        [JsonProperty("level")] public byte Level { get; set; }

        [JsonProperty("gender")] public string Gender { get; set; }

        [JsonProperty("player_id")] public int PlayerId { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("status")] public Status Status { get; set; }

        [JsonProperty("strength")] public long Strength { get; set; }

        [JsonProperty("speed")] public long Speed { get; set; }

        [JsonProperty("dexterity")] public long Dexterity { get; set; }

        [JsonProperty("defense")] public long Defense { get; set; }

        [JsonProperty("total")] public long Total { get; set; }

        [JsonProperty("strength_modifier")] public int StrengthModifier { get; set; }

        [JsonProperty("defense_modifier")] public int DefenseModifier { get; set; }

        [JsonProperty("speed_modifier")] public int SpeedModifier { get; set; }

        [JsonProperty("dexterity_modifier")] public int DexterityModifier { get; set; }

        [JsonProperty("strength_info")] public List<string> StrengthInfo { get; private set; }

        [JsonProperty("defense_info")] public List<string> DefenseInfo { get; private set; }

        [JsonProperty("speed_info")] public List<string> SpeedInfo { get; private set; }

        [JsonProperty("dexterity_info")] public List<string> DexterityInfo { get; private set; }

        [JsonProperty("manual_labor")] public int ManualLabor { get; set; }

        [JsonProperty("intelligence")] public int Intelligence { get; set; }

        [JsonProperty("endurance")] public int Endurance { get; set; }

        [JsonProperty("networth")] public NetworthData Networth { get; set; }

        [JsonProperty("stocks")]
        [JsonConverter(typeof(TornListConverter<Stock>))]
        public List<Stock> Stocks { get; private set; }

        [JsonProperty("honors_awarded")] public List<int> HonorsAwarded { get; private set; }

        [JsonProperty("honors_time")] public List<int> HonorsTime { get; private set; }

        [JsonProperty("medals_awarded")] public List<int> MedalsAwarded { get; private set; }

        [JsonProperty("medals_time")] public List<int> MedalsTime { get; private set; }

        [JsonProperty("display")] public List<DisplayCaseItem> DisplayCase { get; private set; }

        [JsonProperty("inventory")] public List<InventoryItem> Inventory { get; private set; }

        [JsonProperty("bazaar")] public List<BazaarItem> Bazaar { get; private set; }

        [JsonProperty("halloffame")] public HallOfFame HallOfFame { get; set; }

        [JsonProperty("merits")] public Merits Merits { get; set; }

        [JsonProperty("active_gym")] public byte ActiveGym { get; set; }

        [JsonProperty("refills")] public Refills Refills { get; set; }

        [JsonProperty("jobpoints")] public JobPoints JobPoints { get; set; }

        [JsonProperty("properties")]
        [JsonConverter(typeof(TornListConverter<TornProperty>))]
        public List<TornProperty> Properties { get; private set; }

        [JsonProperty("server_time")] public int ServerTime { get; set; }

        [JsonProperty("happy")] public Bar Happy { get; set; }

        [JsonProperty("life")] public Bar Life { get; set; }

        [JsonProperty("energy")] public Bar Energy { get; set; }

        [JsonProperty("nerve")] public Bar Nerve { get; set; }

        [JsonProperty("chain")] public Bar Chain { get; set; }

        [JsonProperty("travel")] public Travel Travel { get; set; }

        [JsonProperty("criminalrecord")] public CriminalRecord CriminalRecord { get; set; }

        [JsonProperty("notifications")] public Notifications Notifications { get; set; }

        [JsonProperty("rank")] public string Rank { get; set; }

        [JsonProperty("property")] public string Property { get; set; }

        [JsonProperty("signup")] public DateTime Signup { get; set; }

        [JsonProperty("awards")] public int Awards { get; set; }

        [JsonProperty("friends")] public int Friends { get; set; }

        [JsonProperty("enemies")] public int Enemies { get; set; }

        [JsonProperty("forum_posts")] public int ForumPosts { get; set; }

        [JsonProperty("karma")] public int Karma { get; set; }

        [JsonProperty("age")] public int Age { get; set; }

        [JsonProperty("role")] public string Role { get; set; }

        [JsonProperty("donator")] public int Donator { get; set; }

        [JsonProperty("property_id")] public int PropertyId { get; set; }

        [JsonProperty("job")] public Job Job { get; set; }

        [JsonProperty("faction")] public Faction Faction { get; set; }

        [JsonProperty("married")] public Married Married { get; set; }

        [JsonProperty("basicicons")] public Dictionary<string, string> BasicIcons { get; private set; }

        [JsonProperty("icons")] public Dictionary<string, string> Icons { get; private set; }

        [JsonProperty("states")] public States States { get; set; }

        [JsonProperty("last_action")] public LastAction LastAction { get; set; }

        [JsonProperty("competition")] public Competition Competition { get; set; }

        [JsonProperty("cooldowns")] public Cooldowns Cooldowns { get; set; }

        [JsonProperty("points")] public int Points { get; set; }

        [JsonProperty("cayman_bank")] public long CaymanBank { get; set; }

        [JsonProperty("vault_amount")] public int? VaultAmount { get; set; }

        [JsonProperty("company_funds")] public long CompanyFunds { get; set; }

        [JsonProperty("daily_networth")] public long DailyNetworth { get; set; }

        [JsonProperty("money_onhand")] public long MoneyOnHand { get; set; }

        [JsonProperty("city_bank")] public CityBank CityBank { get; set; }

        [JsonProperty("job_perks")] public List<string> JobPerks { get; private set; }

        [JsonProperty("property_perks")] public List<string> PropertyPerks { get; private set; }

        [JsonProperty("stock_perks")] public List<string> StockPerks { get; private set; }

        [JsonProperty("merit_perks")] public List<string> MeritPerks { get; private set; }

        [JsonProperty("education_perks")] public List<string> EducationPerks { get; private set; }

        [JsonProperty("enhancer_perks")] public List<string> EnhancerPerks { get; private set; }

        [JsonProperty("company_perks")] public List<string> CompanyPerks { get; private set; }

        [JsonProperty("faction_perks")] public List<string> FactionPerks { get; private set; }

        [JsonProperty("book_perks")] public List<string> BookPerks { get; private set; }

        [JsonProperty("mesages")]
        [JsonConverter(typeof(TornListConverter<Message>))]
        public List<Message> Messages { get; private set; }

        [JsonProperty("events")]
        [JsonConverter(typeof(TornListConverter<TornEvent>))]
        public List<TornEvent> Events { get; private set; }

        [JsonProperty("personalstats")] public PersonalStats PersonalStats { get; set; }

        [JsonProperty("education_current")] public int EducationCurrent { get; set; }

        [JsonProperty("education_timeleft")] public int EducationTimeLeft { get; set; }

        [JsonProperty("education_completed")] public List<int> EducationCompleted { get; private set; }

        [JsonProperty("attacks")]
        [JsonConverter(typeof(TornListConverter<AttackDetailed>))]
        public List<AttackDetailed> Attacks { get; private set; }

        [JsonProperty("revives")]
        [JsonConverter(typeof(TornListConverter<ReviveDetailed>))]
        public List<ReviveDetailed> Revives { get; private set; }

        [JsonProperty("discord")] public Discord Discord { get; set; }

        [JsonProperty("weaponexp")] public List<WeaponExp> WeaponExp { get; private set; }

        [JsonProperty("log")]
        [JsonConverter(typeof(TornListConverter<ActivityLog>))]
        public List<ActivityLog> ActivityLog { get; private set; }

        [JsonProperty("reviving")]
        public float ReviveSkill { get; set; }

        [JsonProperty("racing")]
        public float RacingSkill { get; set; }

        [JsonProperty("hunting")]
        public float HuntingSkill { get; set; }
    }
}