using System;

namespace TryCatchPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			// Add a try/catch block around the following two lines of code to catch the exception
			int num = int.Parse("abc");
			Console.WriteLine(num);


			// Add a try/catch block around this code
			int[] nums = new int[] { 1, 2, 3, 4 };
			Console.WriteLine(nums[10]);
			
		}
	}
}
