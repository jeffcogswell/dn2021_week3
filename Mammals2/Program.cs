using System;

namespace Mammals2
{
	class Mammal
	{
		public string TypeOfHair;
		public int NumberOfTeeth;

		public Mammal(string toHair, int noTeeth)
		{
			TypeOfHair = toHair;
			NumberOfTeeth = noTeeth;
		}
	}

	class Cat : Mammal
	{
		public int RetractClawsCount;
		public Cat(int countClaws, string toHair, int noTeeth) : base(toHair, noTeeth)
		{
			RetractClawsCount = countClaws;
		}
	}

	class Dog : Mammal
	{
		public int NumberOfTricks;
		public bool IsDomesticated;
		public Dog() : base("none selected", 32)
		{
			NumberOfTricks = 0;
			IsDomesticated = true;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Dog Nellie = new Dog();
			Console.WriteLine("Before we set anything, let's print everything out");
			Console.WriteLine(Nellie.NumberOfTricks);
			Console.WriteLine(Nellie.NumberOfTeeth);
			Console.WriteLine(Nellie.TypeOfHair);
			Console.WriteLine(Nellie.IsDomesticated);
			Console.WriteLine("\n\n");
			Nellie.NumberOfTricks = 3;
			Nellie.IsDomesticated = true;
			Nellie.TypeOfHair = "Soft and Long";
			Nellie.NumberOfTeeth = 20;

			Cat DonaldDuck = new Cat(0, "Soft and Short", 18);

			Cat MickeyMouse = new Cat(16, "Soft and Longhaired", 18);

		}
	}
}
