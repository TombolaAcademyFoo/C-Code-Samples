using System;
using FooBank;
using Logging;

namespace CodeSamples.Basics
{
	public static class CastAndTypeConversion
	{
		public static void Test()
		{
			Casts();
			TyeConversions();
		}

		private static void TyeConversions()
		{
			//Some conversions are impossible for a direct cast, type conversion is needed.
			decimal foo = 2123232.8998M;
			Console.WriteLine(foo.ToString());
			Console.WriteLine(foo); //Acutally, underneath Console calls the ToString for us...

			object baz = new object();
			Console.WriteLine(baz); //If the type you are converting to doesn't implement ToString, just the type name is output.
			Console.WriteLine(DateTime.Now.ToString()); //DateTime does override the default ToString behaviour

			//Type conversion from a string is called parsing - though more complex types might need deserialization.

			int quux = int.Parse("244");

			//int qux = int.Parse("Not a number at all in any sense");//Cannot parse - exception called

			//tryparse for completeness
			int corge;

			if (int.TryParse("Not a number at all in any sense", out corge))
			{
				//do whatever with int corge here - this won't work as not a number, but no exception as per straight Parse.
			}



			Console.WriteLine();
		}

		private static void Casts()
		{
			decimal foo = 2.1M;
			//int bar = foo; //this won't work - the framework knows that precision will be lost 2.1 --> 2. Will alert for any value of foo as not generally known at compile time, our example is unrealisitic.
			int bar = (int)foo; //Explicit cast - tells compiler the loss of precision is intended
			Console.WriteLine(bar);

			int baz = 2;
			// decimal quux = (decimal)baz; //Explicit cast, can do this but is redunant, see preffered option below:
			decimal quux = (decimal)baz; //Implicate cast. No information will be lost during cast, so the compiler is fine


			//Types can automatically "cast" down to their super-classes (things they inherit from).
			CurrentAccount myCurrentAccount = new CurrentAccount("12432123", 0M);
			MortgageAccount myMortageAccount = new MortgageAccount("31415927",0M);
			MakeDeposit(myCurrentAccount, 2.00M);
			MakeDeposit(myMortageAccount, 200.00M);
		}

		public static void MakeDeposit(BankAccount bankAccount, decimal amount)
		{
			bankAccount.Deposit(amount);
			Logger.Log("Deposit Made");
		}
	}
}
