using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Basics;
using CodeSamples.BranchingAndLooping;
using CodeSamples.Collections;
using CodeSamples.FilesAndStreams;
using FooBank;

namespace CodeSamples
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount myTestAccount = new BankAccount("12345", 1000M);
			//myTestAccount.Balance = 1000000M; //Not allowed private setter.
			Console.WriteLine(myTestAccount.Balance);
			myTestAccount.Withdraw(250M);
			Console.WriteLine(myTestAccount.Balance);
			Console.WriteLine(myTestAccount.InterestRate);
			myTestAccount.InterestRate = 3M;
			Console.WriteLine(myTestAccount.InterestRate);

			Console.WriteLine("Done");
			Console.ReadKey();
		}
	}
}
