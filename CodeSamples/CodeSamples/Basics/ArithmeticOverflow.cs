using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class ArithmeticOverflow
	{
		public static void Test()
		{

			//The checked keyword makes the .net framework check for overflow
			//It will throw an exception if the max is reached and ome added to it.
			checked
			{
				short i = 1;
				while (true)
				{
					Console.WriteLine(i++);
				}
			}

			////This will overflow silently
			//short j = 1;
			//while (true)
			//{
			//	Console.WriteLine(j++);
			//}
		}


	}
}
