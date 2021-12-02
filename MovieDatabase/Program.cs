using System;
using System.Collections.Generic;

namespace MovieDatabase
{

	class Movie
	{
		private string Title;
		private string Category;

		public Movie(string _Title, string _Category)
		{
			Title = _Title;
			Category = _Category;
		}

		public string GetTitle()
		{
			return Title;
		}

		public string GetCategory()
		{
			return Category;
		}

		public override string ToString()
		{
			return $"{Title} ({Category})";
		}

		public static List<Movie> Movies = new List<Movie>();
	}

	class Program
	{
		static void Main(string[] args)
		{
			Movie mov1 = new Movie("The Godfather", "Drama");
			Movie.Movies.Add(mov1);

			mov1 = new Movie("Black Panther", "Superhero");
			Movie.Movies.Add(mov1);

			mov1 = new Movie("Avengers: Endgame", "Superhero");
			Movie.Movies.Add(mov1);

			// For teaching purposes: The following is an alternate way to do it.
			// Just create the instances and send them right to Movies.Add
			Movie.Movies.Add(new Movie("Toy Story 2", "Animated"));
			Movie.Movies.Add(new Movie("Casablanca", "Drama"));
			Movie.Movies.Add(new Movie("The Thing", "Thriller"));
			Movie.Movies.Add(new Movie("Big Trouble in Little China", "Sci Fi"));
			Movie.Movies.Add(new Movie("Star Wars: A New Hope", "Sci Fi"));

			Console.WriteLine("Welcome to the Movie List Application!");
			Console.WriteLine($"There are {Movie.Movies.Count} movies in this list.");
			Console.Write("What category are you interested in? ");
			string category = Console.ReadLine();

			int found = 0;
			foreach (Movie mov in Movie.Movies)
			{
				if (mov.GetCategory() == category)
				{
					found++;
					Console.WriteLine(mov);
				}
			}
			if (found == 0)
			{
				Console.WriteLine("Sorry we don't have any movies in that category.");
			}

		}
	}
}
