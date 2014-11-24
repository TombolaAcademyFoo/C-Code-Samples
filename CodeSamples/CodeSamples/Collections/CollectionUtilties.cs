using System;
using System.Collections;

namespace CodeSamples.Collections
{
	public static class CollectionUtilties
	{
		//Normally, a utilities class is a bad code smell IMO.
		public static void OuputCollectionListOddEven(ICollection foo)
		{
			foreach (var bar in foo)
			{
				Console.WriteLine("Value {0} is odd: {1} ", bar, ((int)bar % 2) == 1);
			}
		}

		public static void OuputCollectionCollection(ICollection foo)
		{
			foreach (var bar in foo)
			{
				Console.WriteLine(bar);
			}
		}
	}
}
