using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
	public static class DeclaringVariableTypes
	{
		public static void Test()
		{
			bool fooBool = true;
			short fooShort = 1; //16 bit int
			int fooInt = 3; //32 bit int
			long fooLong = 1; //64 bit int

			//Unsigned versions of above = positve numbers only, but can go twice as high
			ushort fooUShort = 1;
			uint fooUInt = 1;
			ulong fooULong = 1;

			//same as short, int, long, different declaration -there are also unsigned versions!
			Int16 fooInt16 = 1;
			Int32 fooInt32 = 1;
			Int64 fooInt63 = 1;


			//uint dooo = -1; //can't do this, negative


			//Maths values have max and min values. Unsigned values have a higher max value
			Console.WriteLine("Max long:" + long.MaxValue);
			Console.WriteLine("Max ulong:" + ulong.MaxValue);
			Console.WriteLine("Min long:" + long.MinValue);
			Console.WriteLine("Min ulong:" + ulong.MinValue);
		}
	}
}
