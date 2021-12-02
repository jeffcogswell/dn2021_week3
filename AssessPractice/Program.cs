using System;
using System.Collections.Generic;

namespace AssessPractice
{
	class Program
	{

		// Function that takes an array of integers, and adds them up and then doubles that sum

		static int SumDouble(int[] myarray)
		{
			// Create a variable that will hold the sum
			int sum = 0;
			// Loop through the array, adding the numbers in the array to the sum
			foreach (int num in myarray)
			{
				sum += num;
			}
			// Return the sum times two
			return sum * 2;
		}

		// Function that takes an array of integers, and returns a list of integers filled with the array values
		// Example:
		//       [ 5, 10, 15, 20 ]
		// returns:
		//       List<int> that has 5, 10, 15, 20 in it

		static List<int> ArrayToList(int[] myarray)
		{
			// Create the list
			List<int> mylist = new List<int>();

			// Loop through the array, adding each number to the list
			foreach (int num in myarray)
			{
				mylist.Add(num);
			}

			return mylist;
		}

		//
		//    Pass in an array such as [2, 4, 6, 8]
		//       and an integer such as 3
		//    The function will return the item that has index 3 (this case, 8)
		//    
		//    Another example:
		//         pass in array [5, 10, 15, 20] and 2 : return 15
		//
		//    Another example:
		//         pass in array [5, 10, 15, 20] and 0: return 5
		//  To pratice try/catch, if the number is outside the bounds of the array
		//  we will return -1.

		static int GetItem(int[] myarray, int index)
		{
			try
			{
				return myarray[index];
			}
			catch
			{
				return -1;
			}
		}

		static int BetterGetItem(int[] myarray, int index)
		{
			if (index >= 0 && index < myarray.Length)
			{
				return myarray[index];
			}
			else
			{
				return -1;
			}
		}

		static void Main(string[] args)
		{
			int[] nums = new int[] { 2, 3, 4, 5 };

			Console.WriteLine(SumDouble(nums));

			Console.WriteLine("\nArray to list demo:");
			List<int> numlist = ArrayToList(nums);
			Console.WriteLine(numlist);
			foreach (int num in numlist)
			{
				Console.WriteLine(num);
			}

			Console.WriteLine("\nTest out our GetItem function");
			Console.WriteLine(GetItem(nums, 0));
			Console.WriteLine(GetItem(nums, 2));
			Console.WriteLine(GetItem(nums, 10));

			Console.WriteLine("\nDictionary pair types");
			Dictionary<string, int> diction = new Dictionary<string, int>();
			diction["one"] = 1;
			diction["two"] = 2;
			diction["three"] = 3;

			foreach (var pair in diction)
			{
				Console.WriteLine($"{pair.Key} {pair.Value}");
			}
		}
	}
}
