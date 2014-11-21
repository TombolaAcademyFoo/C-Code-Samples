using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class DeafaultValues
	{

		static bool myBool;
		static int myInt;
		static decimal myDecimal;
		static string myString;

		public static void Test()
		{
			//Primitive/built-in data types have a default value. For numeric values this is that types representation of 0.
			//Booleans have an equivalent default as 0=false
			Console.WriteLine(myBool);
			Console.WriteLine(myInt);
			Console.WriteLine(myDecimal);

			//string is an odd fish, it is a built in data type, but doesn't behave like the rest, more like other custom types.
			//You will also see this when we cover the difference between reference types and value types. In the current context
			//myString, which is unassigned:
			Console.WriteLine("The value of the unassigned string is '{0}'", myString);
			//The above makes it look like string is an empty string "". WRONG.
			Console.WriteLine("Is unassigned string = \"\": {0}", myString =="");
			//This is the first example of a NULL value. null isn't just nothing (as in we have a 0 value) it represents the **lack of any value at all**
			Console.WriteLine("Is unassigned string = null: {0}", myString == null);

			
			//The problem we have is that nulls are no value at all, so we cannot call properties or methods on a null-valued object.
			//E.g. the standard GetType Method, which gets the .net type of the object.
			Console.WriteLine(myBool.GetType()); //This is OK
			try
			{
				Console.WriteLine(myString.GetType());
			}
			catch (NullReferenceException)
			{
				//This 
				Console.WriteLine("Jinkies - .GetType() caused an exception in our code!");
			}

			//So What?
			//Well, a good proportion of exceptions are NullReferenceExceptions. If we are writing a method we need to defend against null passed by our consumers:
			WriteStringLength("aye aye qt3.14");
			try
			{
				WriteStringLength(myString);
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Zoinks - we didin't protect our code");
			}

			//There is  fixed version of the WriteStringLength at the bottom of this file.

			//Nulls are often considered "evil"
			//Stack overflow discussion: http://programmers.stackexchange.com/questions/12777/are-null-references-really-a-bad-thing
			//Article that provoked it:http://www.infoq.com/presentations/Null-References-The-Billion-Dollar-Mistake-Tony-Hoare , from the man who gave us null! 



		}

		private static void WriteStringLength(string text)
		{
			Console.WriteLine("Passed String length = " + text.Length);
		}

		private static void WriteStringLengthFixed(string text)
		{
			//Now, out of necessity, we've cacked our code up with  with null checks.
			if(string.IsNullOrEmpty(text))
			{
				//This begs the question, is this the correct thing to do, the string doesn't even have 0 characters like "" does.
				Console.WriteLine("Passed String length = " + 0);
			}
			Console.WriteLine("Passed String length = " + text.Length);
		}


		
	}
}

