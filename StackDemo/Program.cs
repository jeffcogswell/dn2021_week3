using System;
using System.Collections.Generic;

namespace StackDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> cards = new Stack<string>();

			cards.Push("10H");
			cards.Push("QD");
			cards.Push("AS");
			Console.WriteLine($"There are {cards.Count} left.");

			string next = cards.Pop();
			Console.WriteLine(next);
			Console.WriteLine($"There are {cards.Count} left.");

			next = cards.Pop();
			Console.WriteLine(next);
			Console.WriteLine($"There are {cards.Count} left.");

			cards.Push("2H");
			next = cards.Pop();
			Console.WriteLine(next);
			Console.WriteLine($"There are {cards.Count} left.");

			next = cards.Pop();
			Console.WriteLine(next);
			Console.WriteLine($"There are {cards.Count} left.");

			if (cards.Count > 0)
			{
				next = cards.Pop();
				Console.WriteLine(next);
			}
			else
			{
				Console.WriteLine("Sorry, no more cards.");
			}

		}
	}
}
