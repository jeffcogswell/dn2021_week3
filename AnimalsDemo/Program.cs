using System;
using System.Collections.Generic;

namespace AnimalsDemo
{

	class Animal
	{
		//
		// Animal has one member:
		//    NumberOfCells
		//
		public int NumberOfCells;
		public Animal()
		{
			NumberOfCells = 0;
		}
		public Animal(int noCells)
		{
			NumberOfCells = noCells;
		}

		public override string ToString()
		{
			return $"This animal has {NumberOfCells} cells.";
		}

		public static List<Animal> Animals = new List<Animal>();
	}

	class Bird : Animal
	{
		//
		// Bird has two members:
		//    NumberOfCells (which it derives from Animal)
		//    LengthOfBeak
		//

		public int LengthOfBeak;
		public Bird() // : base()  -- This part is optional
		{
			LengthOfBeak = 1;
		}
		public Bird(int loBeak, int noCells) : base(noCells)
		{
			LengthOfBeak = loBeak;
		}

		public override string ToString()
		{
			return $"This bird has {NumberOfCells} cells and its beak is {LengthOfBeak} inches long";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			

			Animal a1 = new Animal(1000);
			Animal.Animals.Add(a1);

			Animal a2 = new Animal(5000);
			Animal.Animals.Add(a2);

			Bird b1 = new Bird(20, 10000);
			Animal.Animals.Add(b1);

			foreach (Animal anim in Animal.Animals)
			{
				Console.WriteLine(anim);
			}
		}
	}
}
