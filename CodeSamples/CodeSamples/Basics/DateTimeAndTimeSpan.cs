using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSamples.Basics
{
	public static class DateTimeAndTimeSpan
	{
		public static void Test()
		{
			TestDateTime();
			TestTimeSpan();
		}

		private static void TestDateTime()
		{
			//Can Declare and new up a datetime
			DateTime foo = new DateTime(2014, 11, 21, 13, 51, 30);


			//Can also get the current date & time using a property:
			DateTime currentDateTime = DateTime.Now;

			//But in Tombola we almost always use the UTC time 
			//as we are an international company and it keeps our DBs consistent.

			DateTime currentUtcDateTime = DateTime.UtcNow;

			//Like other types, we have ToString, into which we can pass formatting strings
			//There are lots of these, you need to check them out.
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(DateTime.Now.ToShortDateString());
				Console.WriteLine(DateTime.Now.ToString("U")); // U is shorthand for Universal-full. list of examples herer: http://msdn.microsoft.com/en-us/library/zdtaw1bw%28v=vs.110%29.aspx
				Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.ff"));
				Console.WriteLine(DateTime.UtcNow.ToString("ddd dd/MM/yyyy HH:mm:ss.ff"));
				Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + ".txt");
				WaitASecond();
			}

			//Also Parse methods:
			DateTime christmaDateTime = DateTime.Parse("25/12/2014");
			Console.WriteLine(christmaDateTime.ToString("U"));
		}

		private static void WaitASecond()
		{
			Thread.Sleep(1000);
		}

		private static void TestTimeSpan()
		{
			//Timespan defines the length (span) of time taken:
			TimeSpan timeSpan = new TimeSpan(0,0,0,30); //30 second time span - clunky to instantiate.
			DateTime start = DateTime.UtcNow;
			WaitASecond();
			TimeSpan elapsedTime = DateTime.UtcNow - start;
			Console.WriteLine(elapsedTime.TotalSeconds); //Not that this is unlikely to output exactly 1s

			//Need to ditinguish between Sesconds and TotalSeconds, Minutes and TotalMinutes etc:

			TimeSpan oneHourFiteenMins = new TimeSpan(1,15,0);
			Console.WriteLine("ToString on 30 second timesapan: " + oneHourFiteenMins);

			Console.WriteLine("Days: " + oneHourFiteenMins.Days);
			Console.WriteLine("Hours: " + oneHourFiteenMins.Hours);
			Console.WriteLine("Minutes: " + oneHourFiteenMins.Minutes);
			Console.WriteLine("Seconds: " + oneHourFiteenMins.Seconds);
			Console.WriteLine("Note the seconds value is zero, it is not 1 hour 15 mins and, say, 10 seconds");

			Console.WriteLine("TotalSeconds: " + oneHourFiteenMins.TotalSeconds);
			Console.WriteLine("TotalMinutes: " + oneHourFiteenMins.TotalMinutes);
			Console.WriteLine("TotalHours: " + oneHourFiteenMins.TotalHours);
			Console.WriteLine("TotalDays: " + oneHourFiteenMins.TotalDays);
			Console.WriteLine("Total minutes is the easiest example - 1h15m = (60 + 15) mins = 75 mins");
			Console.WriteLine("Total seconds = 75mins * 60 = 4500 seconds etc");
			Console.WriteLine("Note that we also get fractional values, 1hr 15mins is about 0.05 days.");

			//You can also add or substract a timespan to a datetime to get a new date & time:
			Console.WriteLine(DateTime.Now + oneHourFiteenMins);
		}
	}
}
