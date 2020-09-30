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
using TornJsonData.CommonData;

namespace TornJsonData.TornData
{
    public class CompanyType : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }

        [JsonProperty("default_employees")]
        public int DefaultEmployeeCount { get; set; }

        [JsonProperty("positions")]
        [JsonConverter(typeof(TornListConverter<CompanyPosition>))]
        public List<CompanyPosition> Positions { get; private set; }

        [JsonProperty("stock")]
        [JsonConverter(typeof(TornListConverter<CompanyStock>))]
        public List<CompanyStock> Stock { get; private set; }

        [JsonProperty("specials")]
        [JsonConverter(typeof(TornListConverter<CompanySpecial>))]
        public List<CompanySpecial> Specials { get; private set; }
    }

    public class CompanyPosition : ApiListItem
    {
        [JsonProperty("man_required")]
        public int ManualLaborRequired { get; set; }

        [JsonProperty("int_required")]
        public int IntelligenceRequired { get; set; }

        [JsonProperty("end_required")]
        public int EnduranceRequired { get; set; }

        [JsonProperty("man_gain")]
        public byte ManualLaborGain { get; set; }

        [JsonProperty("int_gain")]
        public byte IntelligenceGain { get; set; }

        [JsonProperty("end_gain")]
        public byte EnduranceGain { get; set; }

        [JsonProperty("special_ability")]
        public string SpecialAbility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CompanySpecial : ApiListItem
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("cost")]
        public short Cost { get; set; }

        [JsonProperty("rating_required")]
        public byte RatingRequired { get; set; }
    }

    public class CompanyStock : ApiListItem
    {
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("rrp")]
        public int RecommendedRetailPrice { get; set; }
    }
}
