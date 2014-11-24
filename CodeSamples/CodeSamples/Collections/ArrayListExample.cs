using System;
using System.Collections;

namespace CodeSamples.Collections
{
	public static class ArrayListExample
	{
		public static void Test()
		{
			ArrayList foo = new ArrayList();
			foo.Add(22);
			foo.Add(99);
			CollectionUtilties.OuputCollectionCollection(foo);
			foo.Add(77);
			int[] bar = { 12, 43, 54 };
			foo.AddRange(bar);
			CollectionUtilties.OuputCollectionCollection(foo);
			CollectionUtilties.OuputCollectionListOddEven(foo);
			//An ArrayList is a List of Objects, can add anything I want to it.
			foo.Add("A whacking great srting value");
			CollectionUtilties.OuputCollectionCollection(foo);
			//OuputArrayListOddEven(foo); //This will now throw an exception - try to cast string to array.
			//Upshot: don't use arraylist.
		

		}


	}
}
