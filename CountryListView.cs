using System;
namespace Country_Lab
{
	public class CountryListView 
	{
		//properties
		public List<Country> Countries { get; set; }

		//contructors
		public CountryListView(List<Country> _countries)
		{
			Countries = _countries;
		}

		//method
		public void Display()
		{
			int counter = 0;
			foreach(Country c in Countries)
			{
				Console.WriteLine($"{counter} {c.Name}");
				counter++;
			}
		}
	}
}

