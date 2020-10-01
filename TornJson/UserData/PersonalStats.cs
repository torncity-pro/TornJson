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

namespace TornJson.UserData
{
    public class PersonalStats
    {
        [JsonProperty("useractivity")] public int UserActivity { get; set; }

        [JsonProperty("itemsbought")] public int ItemsBought { get; set; }

        [JsonProperty("pointsbought")] public int PointsBought { get; set; }

        [JsonProperty("itemsboughtabroad")] public int ItemsBoughtAbroad { get; set; }

        [JsonProperty("moneyinvested")] public long MoneyInvested { get; set; }

        [JsonProperty("investedprofit")] public long InvestedProfit { get; set; }

        [JsonProperty("trades")] public int Trades { get; set; }

        [JsonProperty("itemssent")] public int ItemsSent { get; set; }

        [JsonProperty("auctionsells")] public int ItemsAuctioned { get; set; }

        [JsonProperty("pointssold")] public int PointsSold { get; set; }

        [JsonProperty("attackswon")] public int AttacksWon { get; set; }

        [JsonProperty("attackslost")] public int AttacksLost { get; set; }

        [JsonProperty("attacksdraw")] public int AttacksStalemated { get; set; }

        [JsonProperty("bestkillstreak")] public int BestKillStreak { get; set; }

        [JsonProperty("killstreak")] public int CurrentKillStreak { get; set; }

        [JsonProperty("moneymugged")] public int MoneyMugged { get; set; }

        [JsonProperty("attacksstealthed")] public int AttacksStealthed { get; set; }

        [JsonProperty("attackhits")] public int AttackHits { get; set; }

        [JsonProperty("attackmisses")] public int AttackMisses { get; set; }

        [JsonProperty("attackdamage")] public int AttackDamage { get; set; }

        [JsonProperty("attackcriticalhits")] public int AttackCriticalHits { get; set; }

        [JsonProperty("respectforfaction")] public int RespectForFaction { get; set; }

        [JsonProperty("onehitkills")] public int OneHitKills { get; set; }

        [JsonProperty("defendswon")] public int DefendsWon { get; set; }

        [JsonProperty("defendslost")] public int DefendsLost { get; set; }

        [JsonProperty("defendsstalemated")] public int DefendsStalemated { get; set; }

        [JsonProperty("bestdamage")] public int BestDamage { get; set; }

        [JsonProperty("roundsfired")] public int RoundsFired { get; set; }

        [JsonProperty("yourunaway")] public int YouRunAway { get; set; }

        [JsonProperty("theyrunaway")] public int TheyRunAway { get; set; }

        [JsonProperty("highestbeaten")] public int HighestLevelBeaten { get; set; }

        [JsonProperty("peoplebusted")] public int PeopleBusted { get; set; }

        [JsonProperty("failedbusts")] public int FailedBusts { get; set; }

        [JsonProperty("peoplebought")] public int PeopleBailed { get; set; }

        [JsonProperty("peopleboughtspent")] public int BailFees { get; set; }

        [JsonProperty("virusescoded")] public int VirusesCoded { get; set; }

        [JsonProperty("cityfinds")] public int CityFinds { get; set; }

        [JsonProperty("traveltimes")] public int TimesTraveled { get; set; }

        [JsonProperty("bountiesplaced")] public int BountiesPlaced { get; set; }

        [JsonProperty("bountiesreceived")] public int BountiesReceived { get; set; }

        [JsonProperty("revivesreceived")] public int RevivesReceived { get; set; }

        [JsonProperty("medicalitemsused")] public int MedicalItemsUsed { get; set; }

        [JsonProperty("trainsreceived")] public int TrainsReceived { get; set; }

        [JsonProperty("totalbountyspent")] public int TotalBountySpent { get; set; }

        [JsonProperty("meritsbought")] public int MeritsBought { get; set; }

        [JsonProperty("logins")] public int Logins { get; set; }

        [JsonProperty("mailssent")] public int MailsSent { get; set; }

        [JsonProperty("friendmailssent")] public int FriendMailsSent { get; set; }

        [JsonProperty("factionmailssent")] public int FactionMailsSent { get; set; }

        [JsonProperty("companymailssent")] public int CompanyMailsSent { get; set; }

        [JsonProperty("spousemailssent")] public int SpouseMailsSent { get; set; }

        [JsonProperty("largestmug")] public long LargestMug { get; set; }

        [JsonProperty("rifhits")] public int RifleHits { get; set; }

        [JsonProperty("piehits")] public int PiercingHits { get; set; }

        [JsonProperty("slahits")] public int SlashingHits { get; set; }

        [JsonProperty("mextravel")] public int TimesTraveledMexico { get; set; }

        [JsonProperty("soutravel")] public int TimesTraveledToSouthAfrica { get; set; }

        [JsonProperty("chitravel")] public int TimesTraveledToChina { get; set; }

        [JsonProperty("cantravel")] public int TimesTraveledToCanada { get; set; }

        [JsonProperty("dumpfinds")] public int DumpFinds { get; set; }

        [JsonProperty("dumpsearches")] public int DumpSearches { get; set; }

        [JsonProperty("itemsdumped")] public int ItemsDumped { get; set; }

        [JsonProperty("daysbeendonator")] public int DaysBeenDonator { get; set; }

        [JsonProperty("jailed")] public int Jailed { get; set; }

        [JsonProperty("hospital")] public int Hospital { get; set; }

        [JsonProperty("bazaarcustomers")] public int BazaarCustomers { get; set; }

        [JsonProperty("bazaarsales")] public int BazaarSales { get; set; }

        [JsonProperty("bazaarprofit")] public int BazaarProfit { get; set; }

        [JsonProperty("revives")] public int Revives { get; set; }

        [JsonProperty("grehits")] public int GrenadeHits { get; set; }

        [JsonProperty("caytravel")] public int TimesTraveledToCaymans { get; set; }

        [JsonProperty("smghits")] public int SubMachineGunHits { get; set; }

        [JsonProperty("networth")] public long Networth { get; set; }

        [JsonProperty("auctionswon")] public int AuctionsWon { get; set; }

        [JsonProperty("missioncreditsearned")] public int MissionCreditsEarned { get; set; }

        [JsonProperty("contractscompleted")] public int ContractsCompleted { get; set; }

        [JsonProperty("dukecontractscompleted")]
        public int DukeContractsCompleted { get; set; }

        [JsonProperty("argtravel")] public int TimesTraveledToArgentina { get; set; }

        [JsonProperty("japtravel")] public int TimesTraveledToJapan { get; set; }

        [JsonProperty("missionscompleted")] public int MissionsCompleted { get; set; }

        [JsonProperty("hawtravel")] public int TimesTraveledToHawaii { get; set; }

        [JsonProperty("bloodwithdrawn")] public int BloodWithdrawn { get; set; }

        [JsonProperty("dubtravel")] public int TimesTraveledToDubai { get; set; }

        [JsonProperty("classifiedadsplaced")] public int ClassifiedAdsPlaced { get; set; }

        [JsonProperty("axehits")] public int AxeHits { get; set; }

        [JsonProperty("weaponsbought")] public int WeaponsBought { get; set; }

        [JsonProperty("shohits")] public int ShotgunHits { get; set; }

        [JsonProperty("drugsused")] public int DrugsUsed { get; set; }

        [JsonProperty("cantaken")] public int CannabisTaken { get; set; }

        [JsonProperty("exttaken")] public int EcstasyTaken { get; set; }

        [JsonProperty("opitaken")] public int OpiumTaken { get; set; }

        [JsonProperty("consumablesused")] public int ConsumablesUsed { get; set; }

        [JsonProperty("candyused")] public int CandyUsed { get; set; }

        [JsonProperty("alcoholused")] public int AlcoholUsed { get; set; }

        [JsonProperty("energydrinkused")] public int EnergyDrinksUsed { get; set; }

        [JsonProperty("nerverefills")] public int NerveRefills { get; set; }

        [JsonProperty("organisedcrimes")] public int OrganisedCrimesCompleted { get; set; }

        [JsonProperty("xantaken")] public int XanaxTaken { get; set; }

        [JsonProperty("stockpayouts")] public int StockPayouts { get; set; }

        [JsonProperty("overdosed")] public int TimesOverdosed { get; set; }

        [JsonProperty("traveltime")] public int TravelTime { get; set; }

        [JsonProperty("boostersused")] public int BoostersUsed { get; set; }

        [JsonProperty("territorytime")] public int TerritoryTime { get; set; }

        [JsonProperty("victaken")] public int VicodinTaken { get; set; }

        [JsonProperty("h2hhits")] public int UnarmedHits { get; set; }

        [JsonProperty("bountiescollected")] public int BountiesCollected { get; set; }

        [JsonProperty("totalbountyreward")] public int TotalBountyReward { get; set; }

        [JsonProperty("attacksassisted")] public int AttacksAssisted { get; set; }

        [JsonProperty("lsdtaken")] public int LsdTaken { get; set; }

        [JsonProperty("pishits")] public int PistolHits { get; set; }

        [JsonProperty("switravel")] public int TimesTraveledToSwitzerland { get; set; }

        [JsonProperty("rehabs")] public int Rehabs { get; set; }

        [JsonProperty("rehabcost")] public int RehabCost { get; set; }

        [JsonProperty("booksread")] public int BooksRead { get; set; }

        [JsonProperty("heahits")] public int HeavyHits { get; set; }

        [JsonProperty("awards")] public int Awards { get; set; }

        [JsonProperty("spetaken")] public int SpeedTaken { get; set; }

        [JsonProperty("lontravel")] public int TimesTraveledToLondon { get; set; }

        [JsonProperty("chahits")] public int MachineHits { get; set; }

        [JsonProperty("refills")] public int Refills { get; set; }

        [JsonProperty("racingpointsearned")] public int RacingPointsEarned { get; set; }

        [JsonProperty("raceswon")] public int RacesWon { get; set; }

        [JsonProperty("racesentered")] public int RacesEntered { get; set; }

        [JsonProperty("racingskill")] public int RacingSkill { get; set; }
        
        [JsonProperty("attackswonabroad")] public int AttacksWonAbroad { get; set; }
        
        [JsonProperty("defendslostabroad")] public int DefendsLostAbroad { get; set; }
        
        [JsonProperty("activestreak")] public int ActivityStreak { get; set; }
        
        [JsonProperty("bestactivestreak")] public int  BestActivityStreak { get; set; }
        
        [JsonProperty("jobpointsused")] public int JobPointsUsed { get; set; }
    }
}