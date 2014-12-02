using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooBank;

namespace CodeSamples.Basics
{
	public static class VarExample
	{
		public static void Test()
		{
			//var is not like the JavaScript Var....
			var foo = 1;
			//foo = "hello"; //This would be allowed in JS - but in .net land once it has a type it *must stay that type*.
			MyWhackingGreatFooBarClassName bar = new MyWhackingGreatFooBarClassName();// very long winded  - and can tell what the type is
			var baz = new MyWhackingGreatFooBarClassName(); //This is shorter and you can still easily see what the class is this is OK
			var quux = MyWhackingGreatFooBarClassName.MyMethod(); //DONT DO THIS - cannot tell what immediately what the type is.


			var myBankAccounts = new List<BankAccount>();
			myBankAccounts.Add(new CurrentAccount("12345", 10M));
			myBankAccounts.Add(new MortgageAccount("54321", -10M));
			//LINQ Queries sometimes benefit from the use of var

			var things = from account in myBankAccounts
						 where
						 account.Balance > 0
						 select new { Account = account.AccountNumber, Status = "In The Black - fleece", Balance = account.Balance };

			foreach (var thing in things)
			{
				Console.WriteLine(thing.Account);
				Console.WriteLine(thing.Status);
				Console.WriteLine(thing.Balance);
			}






























		}




		//prented this class is in another file somewhere
		public class MyWhackingGreatFooBarClassName
		{
			public static string MyMethod()
			{
				return "";
			}

		}
	}
}
