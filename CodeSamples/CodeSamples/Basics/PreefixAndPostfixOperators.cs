using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class PreefixAndPostfixOperators
	{
		public static void Test()
		{
			//Postfix & prefix operators.
			int i = 0;
			Console.WriteLine("i = 1");
			Console.WriteLine( "i++ returns " + i++); // Add 1, returning the original value -postfix
			Console.WriteLine("i becomes " + i);
			Console.WriteLine("i++ is postfix = adds one to i but returns the starting value");
			
			
			//Equivalent to postfix operator
			//Console.WriteLine(i);
			//i = i + 1;
			i = 1;
			Console.WriteLine("i = 1");
			Console.WriteLine("++i returns " + i++); // Add 1, returning the resulting value -prefix
			Console.WriteLine("i becomes " + i);
			
			i = 1;
			Console.WriteLine("i = 1");
			Console.WriteLine("++i is prefix = adds one to i and returns the result");

			////Equivalent to prefix operator
			//i = i + 1; 
			//Console.WriteLine(i);

			//Takesies-awaysies versions.
			i = 1;
			Console.WriteLine("i = 1");
			Console.WriteLine("i-- returns" + i--);
			Console.WriteLine("i becomes" + i);

			i = 1;
			Console.WriteLine("i = 1");
			Console.WriteLine("--i =" + --i);


			Console.WriteLine("Note that we tend to use these operators incrementing or decrementing indexes in loops");
		}
	}
}
