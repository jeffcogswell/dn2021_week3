using System;
using System.Collections.Generic;

namespace ClassDemo
{
	class Pen
	{
		public double Length;
		public string Color;
		public double InkLevel;
		public string PenType;

		public void PrintPen()
		{
			Console.WriteLine($"Length: {Length}, Color: {Color}, Ink Level: {InkLevel}, Type: {PenType}");
		}

	}


	class Program
	{
		static void Main(string[] args)
		{
			Pen firstpen = new Pen();
			firstpen.Length = 5;
			firstpen.Color = "red";
			firstpen.InkLevel = 9.2;
			firstpen.PenType = "gel";

			Pen secondpen = new Pen();
			secondpen.Length = 6;
			secondpen.Color = "blue";
			secondpen.InkLevel = 0.5;
			secondpen.PenType = "ballpoint";

			Pen thirdpen = new Pen();
			thirdpen.Length = 5;
			thirdpen.Color = "blue";
			thirdpen.InkLevel = 9.2;
			thirdpen.PenType = "gel";

			Console.WriteLine("First pen:");
			//Console.WriteLine(firstpen.Length);
			//Console.WriteLine(firstpen.Color);
			//Console.WriteLine($"Length: {firstpen.Length}, Color: {firstpen.Color}");
			firstpen.PrintPen();

			Console.WriteLine("Second pen:");
			secondpen.PrintPen();

			Console.WriteLine("Third pen:");
			thirdpen.PrintPen();

			List<Pen> mypens = new List<Pen>();
			mypens.Add(firstpen);
			mypens.Add(secondpen);
			mypens.Add(thirdpen);

			Console.WriteLine("Here are all the pens in the list:");
			foreach (Pen nextpen in mypens)
			{
				nextpen.PrintPen();
			}
		}
	}
}
