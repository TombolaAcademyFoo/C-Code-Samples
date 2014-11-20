using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class BasicMathsOperators
	{
		public static void Test()
		{
			int i = 1;
			Console.WriteLine("i=1");
			Console.WriteLine("Note that the value of i doesn't change, the value is never assign back");
			Console.WriteLine("i+1 =" + (i + 1));
			Console.WriteLine("i-1 =" + (i - 1));
			Console.WriteLine("i*2 =" + (i * 2));
			Console.WriteLine("i/2 =" + (i / 2)); //Not - integer division - get integer!
			Console.WriteLine("Note that the above is integer division: the result is 0.5. so it rounds down");
			Console.WriteLine("11 % 2 =" + (11 % 2)); // Modulus - remainder on an integer division.
			Console.WriteLine("% is the modulus - the remainder when you do a division. 11 /2 = 5,remainder 1");
			Console.WriteLine(Math.Pow(2, 3)); //Not an operator, but needed for examples.	
		}
		
	}
}
