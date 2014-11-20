using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class AssignmentOperators
	{
		public static void Test()
		{
			int j = 7; // = is an assignment operator!
			Console.WriteLine("The value of i changes at each operation, the operator assigns back");
			Console.WriteLine("j=" + j);
			Console.WriteLine(j += 1); //Take the value of j (7) add 1 to it and assign back. j = 8
			Console.WriteLine(j -= 2); //Take the value of j (8) take 2 from it and assign back. j = 6
			Console.WriteLine(j *= 3); //Take the value of j (6) multiply by 3 from it and assign back. j = 18
			Console.WriteLine(j /= 6); //Take the value of j (18) divide by 6 from it and assign back. j = 3
			Console.WriteLine(j %= 2); //Take the value of j (18) modulus it with 2and assign the modulus back. j = 1
		}

	}
}
