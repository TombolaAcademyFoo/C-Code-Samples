using System;

namespace CodeSamples.Basics
{
	public static class ArraysDefaultValues
	{
		static bool myBool;
		static short myShort;
		static int myInt;
		static long myLong;
		static float myFloat;
		static double myDouble;
		static decimal myDecimal;
		static string myString; //Given above, might expect "", but actually  null.

		public static void Test()
		{
			Console.WriteLine(myBool);
			Console.WriteLine(myShort);
			Console.WriteLine(myInt);
			Console.WriteLine(myLong);
			Console.WriteLine(myFloat);
			Console.WriteLine(myDouble);
			Console.WriteLine(myDecimal);
			Console.WriteLine("Default String is null: " + (myString == null));
		}
	}
}
