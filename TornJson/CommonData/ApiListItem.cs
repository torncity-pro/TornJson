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

namespace TornJson.CommonData
{
    public abstract class ApiListItem<T>
    {
        public T Id { get; set; }
    }

    public abstract class IntApiListItem : IApiListItem<int>
    {
        public int Id { get; set; }
        
        public void SetId(string input)
        {
            Id = int.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
        }

        public string GetStringId()
        {
            return Id.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    public abstract class StrApiListItem : IApiListItem<string>
    {
        public string Id { get; set; }
        
        public void SetId(string input)
        {
            Id = input;
        }

        public string GetStringId()
        {
            return Id;
        }
    }
    
    public interface IApiListItem<T> : IApiListItem
    {
        public T Id { get; set; }
    }

    public interface IApiListItem
    {
        public void SetId(string input);
        public string GetStringId();
    }
}