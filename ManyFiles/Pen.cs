using System;
using System.Collections.Generic;
using System.Text;

namespace ManyFiles
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

}
