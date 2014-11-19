using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
	public static class WhyNotToUseFloatingPointTypes
	{
		public static void Test()
		{
			//Don't use float - there are precision problems, same principle applies to "double" type as just a larger float.
			float f1 = 1.0f / 5.0f; //One fifth in maths, near representation of one fifth as float.
			float f2 = (f1 * 5.0f) - 1.0f;   // Maths  = (1/5 * 5) - = 0!. But our double 1/5 is an approximation...
			Console.WriteLine(f2 == 0.0f);   // So this comparison fails.

			//But the same calc works OK for decimals due to the different representation in memory.
			decimal d1 = 1.0M / 5.0M; 
			decimal d2 = (d1 * 5.0M) - 1.0M;   
			Console.WriteLine(d2 == 0.0M);
			//TOP KEK.
		}
	}
}
