using System;


namespace CodeSamples.BranchingAndLooping
{
	
	public static class ForLoops
	{
		static int l = 9;
		public static void Test()
		{
			//Can count up
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("i={0}", i);
			}

			//Or Down
			for (int i = 99; i >= 10; i--)
			{
				Console.WriteLine("i={0}", i);
			}

			//Or use any operation to change the value(s) used in the conditional
			for (int i = 99; i >= 10; i+=-3)
			{
				Console.WriteLine("i={0}", i);
			}


			//Ends as due to integer arithmatic - 0.5 rounds down to 0.
			for (int i = 99; i > 0; i /= 2)
			{
				Console.WriteLine("i={0}", i);
			}

			////Loops must end!!!!!!!
			//for (int i = 0; i != 10; i += 3)
			//{
			//	Console.WriteLine("i={0}", i);
			//}


			LoopsCanBeFlexibleInDeclaration();

			OffByOneError();

			FindFirstNumberDivisibleBy7();
		}

		private static void LoopsCanBeFlexibleInDeclaration()
		{
			// Can define the value outside the loop to increase the scope. 
			// Can also change value inside the loop to end
			int j = 88;
			for ( /*No initialisation*/; j != 99; /*Not altering j here either*/)
			{
				Console.WriteLine("i={0}", j);
				j = 99; //Next iteration of the loop, the condition will become false.
			}

			//To be honest a For loop only really needs a conditional, which must evaluate to true or false.
			//The following would loop forever:
			// for ( ; true ; ) {}
		}

		private static void OffByOneError()
		{
			//Output the numbers 1 --> 10 for the user.
			for (int i = 1; i < 10; i++)
			{
				Console.WriteLine(i);
				//Actually the end conditional is [deliberately] wrong, outputs 1 --> 9. This is called an off by one error.
			}
			//Note off by one is easy to acheive - especially with more complex logic or other looping types.
		}

		private static void FindFirstNumberDivisibleBy7()
		{
			for (int i = 1; i < 10; i++)
			{
				//When I hit the first number that is divisible by 7, stop the loop.
				if ((i%7) == 0)
				{
					break;
				}
			}
			Console.WriteLine("This bit of code must execute after the loop to find the first number divisible by 7");
		}


		//Scope
		//public static Function()
		//{
		//	int j =0;
		//	if(true)
		//	{
		//		Console.WriteLine(k);
		//		int k = 0;
		//		Console.WriteLine(k);
		//	}
		//}

	}
}
