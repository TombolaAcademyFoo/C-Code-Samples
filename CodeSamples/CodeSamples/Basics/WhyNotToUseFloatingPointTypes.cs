using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class WhyNotToUseFloatingPointTypes
	{
		public static void Test()
		{
			//Don't use float unless you have a good reason to, especially with money
			//there are precision problems, same principle applies to "double" type as just a larger float.
			float f1 = 1.0f / 5.0f; //One fifth in maths, near representation of one fifth as float.
			float f2 = (f1 * 5.0f) - 1.0f;   // Maths  = (1/5 * 5) - = 0!. But our double 1/5 is an approximation...
			Console.WriteLine("Using float arithmetic is float ((1/5)* 5) -1 =0" + f2 == 0.0f + "protip: it should be!");   // So this comparison fails.

			//But the same calc works OK for decimals due to the different representation in memory.
			decimal d1 = 1.0M / 5.0M; 
			decimal d2 = (d1 * 5.0M) - 1.0M;
			Console.WriteLine("Using decimal arithmetic is float ((1/5)* 5) -1 =0" + f2 == 0.0f + "protip: it should be!"); 
			Console.WriteLine(d2 == 0.0M);
			//TOP KEK.

			Console.WriteLine("Note that as we don't have fractions of a penny to deal with, we actually store work with integer penny values and divide by 100 when showimg the user pounds and pence");
		}
	}
}
