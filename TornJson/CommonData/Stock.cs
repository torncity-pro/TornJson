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

namespace TornJson.CommonData
{
    public class Stock : IntApiListItem
    {
        [JsonProperty("stock_id")] public int StockId { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("acronym")] public string Acronym { get; set; }

        [JsonProperty("current_price")] public float CurrentPrice { get; set; }

        [JsonProperty("market_cap")] public long MarketCap { get; set; }

        [JsonProperty("total_shares")] public long TotalShares { get; set; }

        [JsonProperty("divident")] public Dividend Dividend { get; set; }

        [JsonProperty("benefit")] public BenefitBlock Benefit { get; set; }

        [JsonProperty("history")] public List<History> History { get; private set; }

        [JsonProperty("last_hour")] public Snapshot LastHour { get; set; }
        
        [JsonProperty("last_day")] public Snapshot LastDay { get; set; }
        
        [JsonProperty("last_week")] public Snapshot LastWeek { get; set; }
        
        [JsonProperty("last_month")] public Snapshot LastMonth { get; set; }
        
        [JsonProperty("last_year")] public Snapshot LastYear { get; set; }

        [JsonConverter(typeof(TornListConverter<StockTransaction>))]
        [JsonProperty("transactions")] public List<StockTransaction> Transactions { get; private set; }
    }

    public class StockTransaction : IntApiListItem
    {
        [JsonProperty("shares")] public int Shares { get; set; }

        [JsonProperty("bought_price")] public float BoughtPrice { get; set; }

        [JsonProperty("time_bought")] public long TimestampBought { get; set; }
    }

    public class Snapshot
    {
        [JsonProperty("change")] public int Change { get; set; }

        [JsonProperty("change_percentage")] public short ChangePercentage { get; set; }
        
        [JsonProperty("start")] public int Start { get; set; }
        
        [JsonProperty("end")] public int End { get; set; }
        
        [JsonProperty("high")] public int High { get; set; }

        [JsonProperty("low")] public int Low { get; set; }
    }

    public class History
    {
        [JsonProperty("timestamp")] public int Timestamp { get; set; }

        [JsonProperty("price")] public float Price { get; set; }

        [JsonProperty("change")] public float Change { get; set; }
    }

    public class BenefitBlock
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("frequency")] public short Frequency { get; set; }

        [JsonProperty("requirement")] public int Requirement { get; set; }

        [JsonProperty("description")] public string Description { get; set; }
    }

    public class Dividend
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }

        [JsonProperty("increment")]
        public byte Increment { get; set; }

        [JsonProperty("progress")]
        public byte Progress { get; set; }

        [JsonProperty("frequency")]
        public byte Frequency { get; set; }
    }
}