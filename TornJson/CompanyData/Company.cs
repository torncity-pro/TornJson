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

namespace TornJson.CompanyData
{
    public class Company
    {
        /// <summary>
        ///     The id that represents this company in url lookups
        /// </summary>
        [JsonProperty("ID")]
        public int CompanyId { get; set; }

        /// <summary>
        ///     The type of company
        /// </summary>
        [JsonProperty("company_type")]
        public byte CompanyType { get; set; }

        /// <summary>
        ///     The star rating out of 10 for the company
        /// </summary>
        [JsonProperty("rating")]
        public byte Rating { get; set; }

        /// <summary>
        ///     The name of the company
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The id of the player who runs the company
        /// </summary>
        [JsonProperty("director")]
        public int Director { get; set; }

        /// <summary>
        ///     The number of employees in the company
        /// </summary>
        [JsonProperty("employees_hired")]
        public byte EmployeesHired { get; set; }

        /// <summary>
        ///     The number of employees capable of being in the company
        /// </summary>
        [JsonProperty("employees_capacity")]
        public byte EmployeesCapacity { get; set; }

        /// <summary>
        ///     The daily profit the company earns
        /// </summary>
        [JsonProperty("daily_income")]
        public long DailyProfit { get; set; }

        /// <summary>
        ///     The weekly profits the company earns
        /// </summary>
        [JsonProperty("weekly_income")]
        public long WeeklyProfit { get; set; }

        /// <summary>
        ///     The number of daily customers
        /// </summary>
        [JsonProperty("daily_customers")]
        public int DailyCustomers { get; set; }

        /// <summary>
        ///     The number of weekly customers
        /// </summary>
        [JsonProperty("weekly_customers")]
        public int WeeklyCustomers { get; set; }

        /// <summary>
        ///     How old the company is
        /// </summary>
        [JsonProperty("days_old")]
        public int DaysOld { get; set; }

        /// <summary>
        ///     A list of employees in the company
        /// </summary>
        [JsonProperty("employees")]
        [JsonConverter(typeof(TornListConverter<Employee>))]
        public List<Employee> Employees { get; private set; }
    }

    /// <summary>
    ///     An employee in the company
    /// </summary>
    public class Employee : IntApiListItem
    {
        /// <summary>
        ///     The name of the employee
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The name of the position the employee has
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        ///     The number of days the employee has been with the company
        /// </summary>
        [JsonProperty("days_in_company")]
        public int DaysInCompany { get; set; }

        /// <summary>
        ///     Gets or sets the last action of the player
        /// </summary>
        [JsonProperty("last_action")]
        public LastAction LastAction { get; set; }

        /// <summary>
        ///     Gets or sets the status of the player
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}