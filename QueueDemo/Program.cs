using System;
using System.Collections.Generic;

namespace QueueDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> people = new Queue<string>();

			people.Enqueue("Sally");
			people.Enqueue("Fred");

			string next = people.Dequeue();
			Console.WriteLine(next);

			people.Enqueue("Sam");
			people.Enqueue("Frank");

			next = people.Dequeue();
			Console.WriteLine(next);

			next = people.Dequeue();
			Console.WriteLine(next);

			next = people.Dequeue();
			Console.WriteLine(next);
		}
	}
}
