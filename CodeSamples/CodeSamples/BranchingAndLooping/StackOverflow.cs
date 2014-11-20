using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.BranchingAndLooping
{
	public static class StackOverflow
	{
		public static void Test()
		{
			// Running this causes a stack overflow excepion
			// The each time the recurse method is called, 
			// it adds another item to the call stack - the Framework's 
			// method of keeping track of which methods have been called.
			// The call stack has finite size - so it will fill up.
			Recurse(1);
			//The problem can be avoided by using a standard loop.
		}

		private static void Recurse(int i)
		{
			//New item added to call stack
			Console.WriteLine(i);
			Recurse(++i);

		}
	}
}
