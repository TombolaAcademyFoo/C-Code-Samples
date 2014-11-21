using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Conditionals
{
	class ToSortOut
	{
		static void Foo()
		{
			//bool i = true;
			//bool j = true;

			/*Console.WriteLine("XOR");
			WriteXor(false, false);
			WriteXor(false, true);
			WriteXor(true, false);
			WriteXor(true, true);
			*/

			//BankAccount bankAccount = new BankAccount();
			//bool isOverDrawn = !bankAccount.IsMortgate && bankAccount.GetBalance() < 0.0M;


			//Console.WriteLine(IsJimmy("jimmy"));
			//Console.WriteLine(IsJimmy("Jimmy"));
			//string name = null;
			//Console.WriteLine(IsJimmy(name));

			//Console.WriteLine(3 & 4);

			int i = 2;
			int j = 4;


			//set k   if i>=j   return    i otherwise    j
			int k = i >= j ? i : j;

			//Above equivalent to:
			//int k = i;
			//if (j > i)
			//{
			//	k = i;
			//}
		}

		//private static bool IsJimmy(string name)
		//{
		//	return name != null && (name.ToLowerInvariant() == "jimmy");
		//}

		//private static void WriteXor(bool i, bool j)
		//{
		//	Console.WriteLine("i={0}\tj={1}\t{2}", i, j, ((i || j)  && !(i & j) ));
		//}

		//public BankAccount CreateNewBankAccountIfNotExists(BankAccount bankAccount)
		//{
		//	return bankAccount == null ? new BankAccount() : bankAccount;
		//}
		////Above equivalent to:
		////public BankAccount CreateNewBankAccountIfNotExists(BankAccount bankAccount)
		////{
		////	if( bankAccount == null)
		////		return new BankAccount();
		////	return bankAccount;
		////}
	}
}
