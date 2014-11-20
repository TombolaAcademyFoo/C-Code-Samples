using System;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace CodeSamples.Basics
{
	public static class Text
	{
		public static void Test()
		{
			char myChar = 'c'; //A Char is a single character. Note that in c# a char must be in single quotes (') 
			string fooString = "The quick brown fox jumped "; //The string must be inside double  quotes (") 

			BuildingUpStrings();
			TypeConversion();

			UnderTheHood();
			AnExampleStringMethod();
		}

		private static void AnExampleStringMethod()
		{
			//String has many methods, some more useful than others - you shoud research these.
			// e.g. split, splits the string into an array at each instance of a character.
			string myString = "The quick brown fox jumped "; //The string must be inside double  quotes (") 
			string[] words = myString.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(words[i]);
			}
		}

		private static void UnderTheHood()
		{
			//Under the hood, strings are char arrays, they can be accessed as if they are:
			string myString = "The quick brown fox jumped "; //The string must be inside double  quotes (") 
			Console.WriteLine(myString[2]); //Underneath string is just a char array and can still index
			for (int i = 0; i < myString.Length; i++)
			{
				Console.WriteLine(myString[i]);
			}
		}

		private static void TypeConversion()
		{
			
			//An example explicit cast:
			object foo = "Hello";
			string bar = (string)foo;

			//It is pretty unusual to cast to or from a string directly. Normally you need to covert from/to.
			//Converting to is easy, everything has a tostring method:
			int i = 2;
			string iAsString = i.ToString();
			Console.WriteLine(iAsString);
			//can sometimes define a format:
			Console.WriteLine(DateTime.Now.ToString("ddd in MMM: yyyy-MM-dd HH:mm:ss"));
			
			//Though sometimes you get the type name back.
			object baz = new object();
			Console.WriteLine(baz.ToString());

			//Console will call .ToString on objects automatically, so be aware of this.
			Console.WriteLine(baz);



			//Going the other way, you rely on the type implemnenting a parse method, or you need to write a parse method yourself.
			//Fundamental types have parsers:
			int j = int.Parse("2");
			decimal k = Decimal.Parse("2.0");
			bool l = bool.Parse("true");

			
			//There are also equivalent tryparse, in case the parse fails:

			int m;
			if(int.TryParse("99",out m))
			{
				Console.WriteLine("Yay it worked: " + m);
			}

			decimal n;
			if(Decimal.TryParse("Not a decimal",out n))
			{
				Console.WriteLine("This won't be executed");
			}

		}

		private static void BuildingUpStrings()
		{
			string myString = "The quick brown fox jumped "; //The string must be inside double  quotes (") 
			//Building up strings: 
			Console.WriteLine(myString + "over the lazy dog"); //Can use + for string concatenation

			//Concatenation can get hard to read for more complicated strings. Can use format strings to simplify items in {n} are replaced in order
			string format = "The Date is {0}, the second thing added is '{1}' , can use a parameter more than once, e.g. date {0}";
			string textToDisplay = String.Format(format, DateTime.Now, "FOO");
			Console.WriteLine(textToDisplay);

			//Commonly methods that output strings will implement a short-form string formatting for you. e.g. Console.WriteLine:
			Console.WriteLine("The Date is {0}, the second thing added is '{1}' , can use a parameter more than once, e.g. date {0}",
										DateTime.UtcNow,
										"FOO");


			//Finally can use stringbuilder:
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < 10; i++ )
			{
				stringBuilder.AppendLine("Line Number: " + i);
			}
			Console.WriteLine(stringBuilder.ToString());

			//*********************************************************************
			//A note about stringbuilder
			//*********************************************************************
			//There is a myth that Stringbuilder that is more efficient in terms of
			//memory and/or speed. This is a myth - it actually depends what you 
			//are doing. Sometimes the benefit is outweighed by the cruft in code 
			//that it creates. Rule of thumb:
			//Use concat (+) if it easily read
			//You can break down concat into several steps
			//String builder should be used in a non-trivial loop, where concat can happen in one step
			//String builder is unsuitable if you want information about the string as you are building it
			//See http://www.yoda.arachsys.com/csharp/stringbuilder.html 
		}
	}
}