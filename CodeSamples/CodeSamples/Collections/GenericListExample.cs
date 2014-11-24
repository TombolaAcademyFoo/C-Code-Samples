using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooBank;

namespace CodeSamples.Collections
{
	public static class GenericListExample
	{
		public static void Test()
		{
			////A list of strings
			//List<string> bar = new List<string>();

			////A list of Bank Accounts
			//List<BankAccount> baz = new List<BankAccount>();

			BasicListOperations();
		}

		private static void BasicListOperations()
		{
			//A list of integers
			List<int> foo = new List<int>();
			foo.Add(22);
			foo.Add(99);
			CollectionUtilties.OuputCollectionCollection(foo);
			foo.Add(77);
			int[] bar = {12, 43, 54};
			foo.AddRange(bar);
			CollectionUtilties.OuputCollectionCollection(foo);
			CollectionUtilties.OuputCollectionListOddEven(foo);
			CollectionUtilties.OuputCollectionCollection(foo);
			List<string> baz = foo.ConvertAll(FunkyToString);
			CollectionUtilties.OuputCollectionCollection(baz);
			Console.WriteLine("Sorted list:");
			baz.Sort();
			CollectionUtilties.OuputCollectionCollection(baz);

			Console.WriteLine("");
			baz.Insert(3, "Not done by the original converter");
			Console.WriteLine("Finding Index of funky 43");
			Console.WriteLine(baz.FindIndex(IsItemWeAreLookingFor));
			//Console.WriteLine(baz.FindIndex(x => x == "43 but funky")); //Same as above using a LINQ predicate.
			CollectionUtilties.OuputCollectionCollection(baz);
		}


		private static string FunkyToString(int orginal)
		{
			return orginal + " but funky";
		}

		private static bool IsItemWeAreLookingFor(string currentValue)
		{
			return currentValue == "43 but funky";
		}
	}
}
