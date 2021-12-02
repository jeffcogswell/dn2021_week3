using System;

namespace OverloadDemo
{

	class Rectangle
	{
		private double Width;
		private double Height;

		// Default constructor (This name means "no parameters")
		public Rectangle()
		{
			Width = 10;
			Height = 10;
		}

		public Rectangle(double W, double H)
		{
			Width = W;
			Height = H;
		}

		public Rectangle(string W, string H)
		{
			Width = double.Parse(W);
			Height = double.Parse(H);
		}

		public double GetArea()
		{
			return Width * Height;
		}
	}


	class Program
	{
		// Name overloading
		// Function overloading
		// Method overloading

		static void PrintSomething()
		{
			Console.WriteLine("Nothing to print!");
		}

		static void PrintSomething(string text)
		{
			Console.WriteLine($"The string is {text}");
		}

		static void PrintSomething(int num)
		{
			Console.WriteLine($"The integer is {num}");
		}

		static void PrintSomething(bool tf)
		{
			Console.WriteLine($"The bool is {tf}");
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(3);
			Console.WriteLine(true);

			PrintSomething("Hello");
			PrintSomething(3);
			PrintSomething(true);
			PrintSomething();

			Rectangle rect1 = new Rectangle(10.00, 20.00);
			Console.WriteLine(rect1.GetArea());

			Rectangle rect2 = new Rectangle();
			Console.WriteLine(rect2.GetArea());

			Rectangle rect3 = new Rectangle("50.0", "60.0");
			Console.WriteLine(rect3.GetArea());
		}
	}
}
