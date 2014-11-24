using System;

namespace CodeSamples.Collections
{
	public class Arrays
	{
		public static void Test()
		{
			ArrayBasics();


			int[] foo = { 0, 1, 2 };
			foo = AddToArray(foo, 99); //Would need similar methods for delete or insert at.
			OutputArray(foo);
		}

		private static int[] AddToArray(int[] originalArray, int newValue)
		{
			int[] newArray = new int[originalArray.Length + 1];
			originalArray.CopyTo(newArray,0);

			/*In older languages: */
			/*for (int i = 0; i < originalArray.Length; i++)
			{
				newArray[i] = originalArray[i];
			}*/
			newArray[originalArray.Length] = newValue;
			return newArray;
		}

		private static void ArrayBasics()
		{
//Original declaration syntacx - 3 arrays, indexes 0,1,2.
			int[] myArray1 = new int[3];
			myArray1[0] = 5;
			myArray1[1] = 698;
			myArray1[2] = 7;
			int[] myArray2 = {44, 43, 42}; //This

			Console.WriteLine("Outputting two arrays basic for");
			OutputArray(myArray1);
			OutputArray(myArray2);

			Console.WriteLine("Outputting two arrays foreach");
			OutputArrayForEach(myArray1);
			OutputArrayForEach(myArray2);

			//Multi Demensional Array
			int[,] foo = new int[3, 2];
			foo[0, 0] = 0;
			foo[0, 1] = 1;
			foo[1, 0] = 10;
			foo[1, 1] = 11;
			foo[2, 0] = 22;
			foo[2, 1] = 23;
			Output2dArray(foo);
		}


		public static void OutputArray(int[] values)
		{
			for(int i=0; i< values.Length; i++)
			{
				Console.WriteLine("indexer={0}, value={1}",i, values[i]);		
			}
		}

		private static void OutputArrayForEach(int[] values)
		{
			foreach (int value in values)
			{
				Console.WriteLine("No indexerAvailable, value={0}", value);
			}
		}

		public static void Output2dArray(int[,] twoDArray)
		{
			for (int i = 0; i <= twoDArray.GetUpperBound(0); i++)
			{
				for (int j = 0; j<= twoDArray.GetUpperBound(1); j++)
				{
					Console.WriteLine("indexer=({0},{1}), value={2}", i, j, twoDArray[i,j]);
				}
			}


		}
	}
}
