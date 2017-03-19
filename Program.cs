using System;

namespace WOnderLandCalculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Start:
			int num01;
			int num02;
		
			Console.Write("type a number to be multiplied: ");
			num01 = Convert.ToInt32 (Console.ReadLine());
			Console.Write("type a second number to be multiplied: ");
		    num02 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("the result is " + num01 * num02);
			Console.ReadKey();
			goto Start; //jumps to "Start:"
		}
	}
}
