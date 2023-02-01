using System;
using System.ComponentModel;

namespace Country_Lab
{
	public class CountryController
	{
        List<Country> countryDB { get; set; }
        List<Country> colors = new List<Country>();

		public CountryController()
		{
			countryDB = new List<Country>
			{
				new Country ("Sicily", "Europe", new List<string> {"Red,Yellow"}),
                new Country ("Japan", "Asia", new List<string> {"Red,White"}),
                new Country ("Italy", "Europe", new List<string> {"Red,White,Green"}),
                new Country ("Greece", "Europe", new List<string> {"White,Blue"}),

            }; 

		}

		public void CountryAction(Country c)
		{
			CountryView view = new CountryView(c);
			view.Display();
		}

		public void WelcomeAction()
		{
			bool runWhile = true;
			while (runWhile)
			{
                CountryListView places = new CountryListView(countryDB);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");

                places.Display();
                int choice = int.Parse(Console.ReadLine());

                Country C = countryDB[choice];
                CountryAction(C);

				Console.WriteLine("Would you like to go again? y/n");
				string choices = Console.ReadLine();
				if(choices == "y")
				{
					runWhile = true;
					
				}
				else if(choices == "n")
				{
					runWhile = false;
					Console.WriteLine("Thanks for viewing!");
				}

            }
			
		
		}

      
    }
}

