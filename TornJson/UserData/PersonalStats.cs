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

namespace TornJson.UserData
{
    public class PersonalStats
    {
        [JsonProperty("activestreak")] public int ActivityStreak { get; set; }
        [JsonProperty("alcoholused")] public int AlcoholUsed { get; set; }
        [JsonProperty("argtravel")] public int TimesTraveledToArgentina { get; set; }
        [JsonProperty("arrestsmade")] public int ArrestsMade { get; set; }
        [JsonProperty("attackcriticalhits")] public int AttackCriticalHits { get; set; }
        [JsonProperty("attackdamage")] public int AttackDamage { get; set; }
        [JsonProperty("attackhits")] public int AttackHits { get; set; }
        [JsonProperty("attackmisses")] public int AttackMisses { get; set; }
        [JsonProperty("attacksassisted")] public int AttacksAssisted { get; set; }
        [JsonProperty("attacksdraw")] public int AttacksStalemated { get; set; }
        [JsonProperty("attackslost")] public int AttacksLost { get; set; }
        [JsonProperty("attacksstealthed")] public int AttacksStealthed { get; set; }
        [JsonProperty("attackswon")] public int AttacksWon { get; set; }
        [JsonProperty("attackswonabroad")] public int AttacksWonAbroad { get; set; }
        [JsonProperty("auctionsells")] public int ItemsAuctioned { get; set; }
        [JsonProperty("auctionswon")] public int AuctionsWon { get; set; }
        [JsonProperty("awards")] public int Awards { get; set; }
        [JsonProperty("axehits")] public int AxeHits { get; set; }
        [JsonProperty("bazaarcustomers")] public int BazaarCustomers { get; set; } // Private
        [JsonProperty("bazaarprofit")] public int BazaarProfit { get; set; } // Private
        [JsonProperty("bazaarsales")] public int BazaarSales { get; set; } // Private
        [JsonProperty("bestactivestreak")] public int BestActivityStreak { get; set; }
        [JsonProperty("bestdamage")] public int BestDamage { get; set; }
        [JsonProperty("bestkillstreak")] public int BestKillStreak { get; set; }
        [JsonProperty("bloodwithdrawn")] public int BloodWithdrawn { get; set; }
        [JsonProperty("booksread")] public int BooksRead { get; set; }
        [JsonProperty("boostersused")] public int BoostersUsed { get; set; }
        [JsonProperty("bountiescollected")] public int BountiesCollected { get; set; }
        [JsonProperty("bountiesplaced")] public int BountiesPlaced { get; set; }
        [JsonProperty("bountiesreceived")] public int BountiesReceived { get; set; }
        [JsonProperty("candyused")] public int CandyUsed { get; set; }
        [JsonProperty("cantaken")] public int CannabisTaken { get; set; }
        [JsonProperty("cantravel")] public int TimesTraveledToCanada { get; set; }
        [JsonProperty("caytravel")] public int TimesTraveledToCaymans { get; set; }
        [JsonProperty("chahits")] public int MachineHits { get; set; }
        [JsonProperty("chitravel")] public int TimesTraveledToChina { get; set; }
        [JsonProperty("cityfinds")] public int CityFinds { get; set; }
        [JsonProperty("cityitemsbought")] public int CityItemsBought { get; set; }
        [JsonProperty("classifiedadsplaced")] public int ClassifiedAdsPlaced { get; set; }
        [JsonProperty("companymailssent")] public int CompanyMailsSent { get; set; }
        [JsonProperty("consumablesused")] public int ConsumablesUsed { get; set; }
        [JsonProperty("contractscompleted")] public int ContractsCompleted { get; set; }
        [JsonProperty("daysbeendonator")] public short DaysBeenDonator { get; set; }
        [JsonProperty("defendslost")] public int DefendsLost { get; set; }
        [JsonProperty("defendslostabroad")] public int DefendsLostAbroad { get; set; }
        [JsonProperty("defendsstalemated")] public int DefendsStalemated { get; set; }
        [JsonProperty("defendswon")] public int DefendsWon { get; set; }
        [JsonProperty("defense")] public long Defense { get; set; } // Private
        [JsonProperty("dexterity")] public long Dexterity { get; set; } // Private
        [JsonProperty("drugsused")] public int DrugsUsed { get; set; }
        [JsonProperty("dubtravel")] public int TimesTraveledToDubai { get; set; }
        [JsonProperty("dukecontractscompleted")] public int DukeContractsCompleted { get; set; }
        [JsonProperty("dumpfinds")] public int DumpFinds { get; set; }
        [JsonProperty("dumpsearches")] public int DumpSearches { get; set; }
        [JsonProperty("elo")] public short EloRating { get; set; }
        [JsonProperty("endurance")] public int Endurance { get; set; } // Private
        [JsonProperty("energydrinkused")] public int EnergyDrinksUsed { get; set; }
        [JsonProperty("exttaken")] public int EcstasyTaken { get; set; }
        [JsonProperty("factionmailssent")] public int FactionMailsSent { get; set; }
        [JsonProperty("failedbusts")] public int FailedBusts { get; set; }
        [JsonProperty("friendmailssent")] public int FriendMailsSent { get; set; }
        [JsonProperty("grehits")] public int GrenadeHits { get; set; }
        [JsonProperty("h2hhits")] public int UnarmedHits { get; set; }
        [JsonProperty("hawtravel")] public int TimesTraveledToHawaii { get; set; }
        [JsonProperty("heahits")] public int HeavyHits { get; set; }
        [JsonProperty("highestbeaten")] public int HighestLevelBeaten { get; set; }
        [JsonProperty("hollowammoused")] public int HollowAmmoUsed { get; set; }
        [JsonProperty("hospital")] public int Hospital { get; set; }
        [JsonProperty("incendiaryammoused")] public int IncendiaryAmmoUsed { get; set; }
        [JsonProperty("intelligence")] public int Intelligence { get; set; } // Private        
        [JsonProperty("investedprofit")] public long InvestedProfit { get; set; } // Private
        [JsonProperty("itemsbought")] public int ItemsBought { get; set; }
        [JsonProperty("itemsboughtabroad")] public int ItemsBoughtAbroad { get; set; }
        [JsonProperty("itemsdumped")] public int ItemsDumped { get; set; }
        [JsonProperty("itemssent")] public int ItemsSent { get; set; }
        [JsonProperty("jailed")] public int Jailed { get; set; }
        [JsonProperty("japtravel")] public int TimesTraveledToJapan { get; set; }
        [JsonProperty("jobpointsused")] public int JobPointsUsed { get; set; }
        [JsonProperty("kettaken")] public int KetamineTaken { get; set; }
        [JsonProperty("killstreak")] public int CurrentKillStreak { get; set; } // Private
        [JsonProperty("largestmug")] public long LargestMug { get; set; }
        //[JsonProperty("logins")] public int Logins { get; set; }
        [JsonProperty("lontravel")] public int TimesTraveledToLondon { get; set; }
        [JsonProperty("lsdtaken")] public int LsdTaken { get; set; }
        [JsonProperty("machits")] public int MachineGunHits { get; set; }
        [JsonProperty("mailssent")] public int MailsSent { get; set; }
        [JsonProperty("manuallabor")] public int ManualLabor { get; set; } // Private
        [JsonProperty("medicalitemsused")] public int MedicalItemsUsed { get; set; }
        [JsonProperty("meritsbought")] public int MeritsBought { get; set; }
        [JsonProperty("mextravel")] public int TimesTraveledMexico { get; set; }
        [JsonProperty("missioncreditsearned")] public int MissionCreditsEarned { get; set; }
        [JsonProperty("missionscompleted")] public int MissionsCompleted { get; set; }
        [JsonProperty("moneyinvested")] public long MoneyInvested { get; set; } // Private
        [JsonProperty("moneymugged")] public long MoneyMugged { get; set; }
        [JsonProperty("nerverefills")] public int NerveRefills { get; set; }
        [JsonProperty("networth")] public long Networth { get; set; }
        [JsonProperty("networthauctionhouse")] public long NetworthAuctionHouse { get; set; } // Private
        [JsonProperty("networthbank")] public long NetworthBank { get; set; } // Private
        [JsonProperty("networthbazaar")] public long NetworthBazaar { get; set; } // Private
        [JsonProperty("networthbookie")] public long NetworthBookie { get; set; } // Private
        [JsonProperty("networthcayman")] public long NetworthCayman { get; set; } // Private
        [JsonProperty("networthcompany")] public long NetworthCompany { get; set; } // Private
        [JsonProperty("networthdisplaycase")] public long NetworthDisplayCase { get; set; } // Private
        [JsonProperty("networthitems")] public long NetworthItems { get; set; } // Private
        [JsonProperty("networthloan")] public long NetworthLoan { get; set; } // Private
        [JsonProperty("networthpending")] public long NetworthPending { get; set; } // Private
        [JsonProperty("networthpiggybank")] public long NetworthPiggyBank { get; set; } // Private
        [JsonProperty("networthpoints")] public long NetworthPoints { get; set; } // Private
        [JsonProperty("networthproperties")] public long NetworthProperties { get; set; } // Private
        [JsonProperty("networthstockmarket")] public long NetworthStockMarket { get; set; } // Private
        [JsonProperty("networthunpaidfees")] public long NetworthUnpaidFees { get; set; } // Private
        [JsonProperty("networthvault")] public int NetworthVault { get; set; } // Private
        [JsonProperty("networthwallet")] public long NetworthWallet { get; set; } // Private
        [JsonProperty("onehitkills")] public int OneHitKills { get; set; }
        [JsonProperty("opitaken")] public int OpiumTaken { get; set; }
        [JsonProperty("organisedcrimes")] public int OrganisedCrimesCompleted { get; set; }
        [JsonProperty("overdosed")] public int TimesOverdosed { get; set; }
        [JsonProperty("pcptaken")] public int PcpTaken { get; set; }
        [JsonProperty("peoplebought")] public int PeopleBailed { get; set; }
        [JsonProperty("peopleboughtspent")] public long BailFees { get; set; }
        [JsonProperty("peoplebusted")] public int PeopleBusted { get; set; }
        [JsonProperty("personalsplaced")] public int PersonalsPlaced { get; set; }
        [JsonProperty("piehits")] public int PiercingHits { get; set; }
        [JsonProperty("piercingammoused")] public int PiercingAmmoUsed { get; set; }
        [JsonProperty("pishits")] public int PistolHits { get; set; }
        [JsonProperty("pointsbought")] public int PointsBought { get; set; }
        [JsonProperty("pointssold")] public int PointsSold { get; set; } // Private
        [JsonProperty("racesentered")] public int RacesEntered { get; set; }
        [JsonProperty("raceswon")] public int RacesWon { get; set; }
        [JsonProperty("racingpointsearned")] public int RacingPointsEarned { get; set; }
        [JsonProperty("racingskill")] public int RacingSkill { get; set; } // Private
        [JsonProperty("receivedbountyvalue")] public long ReceivedBountyValue { get; set; }
        [JsonProperty("refills")] public int Refills { get; set; }
        [JsonProperty("rehabcost")] public long RehabCost { get; set; }
        [JsonProperty("rehabs")] public int Rehabs { get; set; }
        [JsonProperty("respectforfaction")] public int RespectForFaction { get; set; }
        [JsonProperty("retals")] public int Retaliations { get; set; }
        [JsonProperty("revives")] public int Revives { get; set; }
        [JsonProperty("reviveskill")] public int ReviveSkill { get; set; }
        [JsonProperty("revivesreceived")] public int RevivesReceived { get; set; }
        [JsonProperty("rifhits")] public int RifleHits { get; set; }
        [JsonProperty("roundsfired")] public int RoundsFired { get; set; }
        [JsonProperty("shohits")] public int ShotgunHits { get; set; }
        [JsonProperty("shrtaken")] public int ShroomsTaken { get; set; }
        [JsonProperty("slahits")] public int SlashingHits { get; set; }
        [JsonProperty("smghits")] public int SubMachineGunHits { get; set; }
        [JsonProperty("soutravel")] public int TimesTraveledToSouthAfrica { get; set; }
        [JsonProperty("specialammoused")] public int SpecialAmmoUsed { get; set; }
        [JsonProperty("speed")] public long Speed { get; set; } // Private
        [JsonProperty("spetaken")] public int SpeedTaken { get; set; }
        [JsonProperty("spousemailssent")] public int SpouseMailsSent { get; set; }
        [JsonProperty("statenhancersused")] public int StatEnhancersUsed { get; set; }
        [JsonProperty("stockfees")] public long StockFees { get; set; } // Private
        [JsonProperty("stocklosses")] public long StockLosses { get; set; } // Private
        [JsonProperty("stockpayouts")] public int StockPayouts { get; set; } // Private
        [JsonProperty("stockprofits")] public long StockProfits{ get; set; } // Private
        [JsonProperty("switravel")] public int TimesTraveledToSwitzerland { get; set; }
        [JsonProperty("territoryjoins")] public int TerritoryJoins { get; set; }
        [JsonProperty("territorytime")] public int TerritoryTime { get; set; }
        [JsonProperty("theyrunaway")] public int TheyRunAway { get; set; }
        [JsonProperty("timesloggedin")] public int TimesLoggedIn { get; set; }
        [JsonProperty("tokenrefills")] public int TokenRefills { get; set; }
        [JsonProperty("totalbountyreward")] public int TotalBountyReward { get; set; }
        [JsonProperty("totalbountyspent")] public int TotalBountySpent { get; set; }
        [JsonProperty("totalstats")] public long TotalStats { get; set; } // Private
        [JsonProperty("tracerammoused")] public int TracerAmmoUsed { get; set; }
        [JsonProperty("trades")] public int Trades { get; set; } // Private
        [JsonProperty("trainsreceived")] public int TrainsReceived { get; set; }
        [JsonProperty("traveltime")] public int TravelTime { get; set; }
        [JsonProperty("traveltimes")] public int TimesTraveled { get; set; }
        [JsonProperty("unarmoredwon")] public int UnarmoredAttacksWon { get; set; }
        [JsonProperty("useractivity")] public int UserActivity { get; set; }
        [JsonProperty("victaken")] public int VicodinTaken { get; set; }
        [JsonProperty("virusescoded")] public int VirusesCoded { get; set; }
        [JsonProperty("weaponsbought")] public int WeaponsBought { get; set; }
        [JsonProperty("xantaken")] public int XanaxTaken { get; set; }
        [JsonProperty("yourunaway")] public int YouRunAway { get; set; }
    }
}