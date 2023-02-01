using System;
namespace Country_Lab
{
	public class CountryView
	{
		//properties
		public Country DisplayCountry { get; set; }

		//contructors
		public CountryView(Country _country)
		{
			DisplayCountry = _country;
		}

		//methods
		public void Display()
		{
			Console.WriteLine($"{DisplayCountry.Name}, {DisplayCountry.Continent}, {string.Join(", ", DisplayCountry.Colors)}");

        }
	}
}

