using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using CodeSamples.Basics;

namespace CodeSamples.FilesAndStreams
{
	public static class FileIO
	{
		public static void Test()
		{
			//ReadingIn();
			//FakeHollyWoodTyper();
			WritingOut();
			
		}
		public static void ReadingIn()
		{
			try
			{
				StreamReader streamReader = new StreamReader(@"D:\OneDrive\Documents\Apprentices\Resources\C-Code-Samples\CodeSamples\Hunger.txt", Encoding.UTF8);
				Console.WriteLine(streamReader.Read()); //Reads Char, as integer - need to worry about encoding....
				Console.WriteLine(streamReader.ReadLine()); //Try changing the encoding on the stream reader to UTF32 - it isn't so you'll get "???? ????"
				Console.WriteLine(streamReader.ReadToEnd()); //Need to be careful about this with big files - memory can be a concern.
				streamReader.Close();// Method 1 - close the stream explicitly - good reasons not to do this - won't close on exception, could close in finally block, but then need to increase the scope of the stream reader.

				//Read again in one chunk, but use using - this will close & destroy the stream for you. Preferred method.
				//Using Text reader, but could have used StreamReader
				using(TextReader textReader = new StreamReader(@"D:\OneDrive\Documents\Apprentices\Resources\C-Code-Samples\CodeSamples\Hunger.txt", Encoding.UTF8))
				{
					Console.WriteLine(textReader.ReadToEnd()); //Need to be careful about this with big files - memory can be a concern.	
				}
			}
			catch (IOException ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex);
				Console.ResetColor();
			}
		}

		public static void FakeHollyWoodTyper()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				TextReader textReader = new StreamReader(@"D:\OneDrive\Documents\Apprentices\Resources\C-Code-Samples\CodeSamples\Hunger.txt", Encoding.UTF8);

				//Peek gets the next character, without moving the position of the read.
				while (textReader.Peek() > -1)
				{
					Random random = new Random();
					int pause = (int)(random.NextDouble() * 10.00) + 10;
					Thread.Sleep(pause);
					char characterToType = (char)textReader.Read();
					Console.Write(characterToType);
				}
				Console.WriteLine();
				
			}
			catch (IOException ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex);
				Console.ResetColor();
			}
			finally
			{
				Console.ResetColor();
			}
		}

		public static void WritingOut()
		{
			try
			{
				//The false value is unecessary here, but setting it to true appends to the end of the file if it already has content.
				using(TextWriter textWriter = new StreamWriter(@"D:\OneDrive\Documents\Apprentices\Resources\C-Code-Samples\CodeSamples\output.txt", false, Encoding.UTF8))
				{
					textWriter.Write("Hello");
					textWriter.WriteLine();
					textWriter.Flush();
					textWriter.WriteLine("This is on a new line.");
				}
			}
			catch (IOException ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex);
				Console.ResetColor();
			}
		}

	}
}
