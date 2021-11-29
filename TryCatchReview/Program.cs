using System;

namespace TryCatchReview
{
	class Program
	{

		static void Practice()
		{
			Console.WriteLine("Ready to practice!");
			string entry = "abc";
			try
			{
				Console.WriteLine("First line of try block");
				int num = int.Parse(entry);
				Console.WriteLine("We just called parse! We have an integer");
				Console.WriteLine(num);
				Console.WriteLine("Done parsing!");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Oops! We caught an exception!");
				Console.WriteLine("Done with catch block!");
			}
			Console.WriteLine("Done with practice!");
		}

		static int Practice2()
		{
			string entry = Console.ReadLine();
			//int num = int.Parse(entry);
			//return num;
			try
			{
				int num = int.Parse(entry);
				return num;
			}
			catch (Exception ex)
			{
				return -1000;
			}
		}

		static int ReadInt()
		{
			bool done = false;
			int result = 0;
			while (!done)
			{
				string entry = Console.ReadLine();
				try
				{
					Console.WriteLine("Time to call parse!");
					result = int.Parse(entry);
					done = true;
					Console.WriteLine("Everything looks good, setting done to true.");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Sorry, that isn't an integer. Please try again.");
				}
				Console.WriteLine("Last line of the loop!");
			}
			return result;
		}

		static void Main(string[] args)
		{
			int number = Practice2();
			Console.WriteLine($"You entered {number}");

			//Console.Write("Please enter an integer: ");
			//int num = ReadInt();
			//Console.WriteLine($"You entered {num}");
		}
	}
}
