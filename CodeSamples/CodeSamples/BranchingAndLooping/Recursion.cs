using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSamples.BranchingAndLooping
{
	public static class Recursion
	{
		public static void Test()
		{
			//Breaks DRY rule
			//Console.WriteLine("Enter the number you want to add to the average");
			//string value = Console.ReadLine();
			//RollingAverage(Decimal.Parse(value), 1.0M);
			StackOverFlow(1);

		}

		public static void RollingAverage(decimal currentAverage, decimal countOfNumbers)
		{
			//Obviously, wouldn't normally doe something like this in real life - this is for an example.
			Console.WriteLine("Enter the number you want to add to the average");
			string value = Console.ReadLine();
			decimal newValue = Decimal.Parse(value);
			decimal newAverage = (newValue + (currentAverage * countOfNumbers)) / (countOfNumbers + 1.0M);
			Console.WriteLine(newAverage);
			//Suprious end condition
			if (newAverage <= 1000000M)
			{
				//Recursion Here
				RollingAverage(newAverage, ++countOfNumbers);
			}
		}



		public static void StackOverFlow (int i)
		{
			//Console.WriteLine(i);
			//StackOverFlow(++i);
			//if (i > Int64.MaxValue)
			//	return;
		}
	}
}
