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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace TornJson.CommonData
{
    public class Stock : ApiListItem
    {
        [JsonProperty("stock_id")] public int StockId { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("acronym")] public string Acronym { get; set; }

        [JsonProperty("director")] public string Director { get; set; }

        [JsonProperty("current_price")] public float CurrentPrice { get; set; }

        [JsonProperty("market_cap")] public long MarketCap { get; set; }

        [JsonProperty("total_shares")] public long TotalShares { get; set; }

        [JsonProperty("available_shares")] public long AvailableShares { get; set; }

        [JsonProperty("forecast")] public string Forecast { get; set; }

        [JsonProperty("demand")] public string Demand { get; set; }

        [JsonProperty("benefit")] public BenefitBlock Benefit { get; set; }

        [JsonProperty("history")] public List<History> History { get; private set; }
    }

    public class History
    {
        [JsonProperty("timestamp")] public int Timestamp { get; set; }

        [JsonProperty("display_time")] public string DisplayTime { get; set; }

        [JsonProperty("price")] public float Price { get; set; }

        [JsonProperty("change")] public float Change { get; set; }

        [JsonProperty("available_shares")] public long AvailableShares { get; set; }

        [JsonProperty("current_shares")] public long CurrentShares { get; set; }
    }

    public class BenefitBlock
    {
        [JsonProperty("requirement")] public int Requirement { get; set; }

        [JsonProperty("description")] public string Description { get; set; }
    }
}