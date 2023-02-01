using System;
namespace Country_Lab
{
	public class Country
	{
		//properties
		public string Name { get; set; }
		public string Continent { get; set; }
		public List<string> Colors { get; set; }

		//contructor
		public Country(string _name, string _continent, List<string> _colors)
		{
			Name = _name;
			Continent = _continent;
			Colors = _colors;
		}
	}
}

