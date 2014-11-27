using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Collections
{
	public static class DictionaryExamples
	{
		public static void Test()
		{
			//Aim: to store the list of e-mail addresses for a given user.
			//Each user has a unique username, any number of e-mail addresses.
			//Both usernames and e-mails are strings for a simpler example.
			Dictionary<string, List<string>> userEmailAddresses = new Dictionary<string, List<string>>();

			//Adding is a matter of adding the key and value
			userEmailAddresses.Add("LordKitchener", new List<string>() ); //No e-mails...
			userEmailAddresses.Add("Seagull", new List<string>() { "seagull@seaside.com" });
			userEmailAddresses.Add("SunderlandUnveristy", new List<string>() { "admin@sunderland.ac.uk", "liberry@sunderland.ac.uk", "digs@sunderland.ac.uk" });
			userEmailAddresses.Add("NewcastleUnveristy", new List<string>() { "admin@ncl.ac.uk", "liberry@ncl.ac.uk", "digs@ncl.ac.uk", "poopsmith@ncl.ac.uk" });

			//"Normal" Access via key
			WriteOutUserEmails("LordKitchener", userEmailAddresses["LordKitchener"]);
			WriteOutUserEmails("Seagull", userEmailAddresses["Seagull"]);
			WriteOutUserEmails("SunderlandUnveristy", userEmailAddresses["SunderlandUnveristy"]);

			Console.WriteLine();
			//Better access using keys:
			foreach(string key in userEmailAddresses.Keys)
			{
				WriteOutUserEmails(key, userEmailAddresses[key]);
			}


			Console.WriteLine();
			//Looping on dictionary directly
			foreach(KeyValuePair<string,List<string>>kvp in userEmailAddresses)
			{
				WriteOutUserEmails(kvp.Key, kvp.Value);
			}


			//Can access the value via the key directly:

			userEmailAddresses["LordKitchener"].Add("LordKitchener@ww1.com");
			userEmailAddresses["NewcastleUnveristy"].Clear();
			if (!userEmailAddresses.ContainsKey("NewcastleUnveristy"))
			{
				//If the following line were executed, youd get an exception adding
				//Can't add the same key twice
				userEmailAddresses.Add("NewcastleUnveristy", new List<string>());
			}
			Console.WriteLine();
			//Better access using keys:
			foreach (string key in userEmailAddresses.Keys)
			{
				WriteOutUserEmails(key, userEmailAddresses[key]);
			}

		}


		private static void WriteOutUserEmails(string userName, List<string> eMails)
		{
			Console.WriteLine("The user {0} has the following:", userName );

			foreach (string eMail in eMails)
			{
				Console.WriteLine("\t{0}", eMail);
			}
		}
	}
}
