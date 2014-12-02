using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;

namespace FooBank
{
	public class BankAccount
	{


		public BankAccount(string accountNumber, decimal initialBalance)
		{
			AccountNumber = accountNumber;
			Balance = initialBalance;
			InterestRate = 0.01M;
			AccountHolders = new List<AccountHolder>();
		}

		public void Withdraw(decimal amount)
		{
			Logger.Log( "Widthraw");
			Balance -= amount;
		}

		public void Deposit(decimal amount)
		{
			Logger.Log( "Deposit");
			Balance += amount;
		}


		public void PayAnnualInterest()
		{
			decimal interestToPay = (Balance * InterestRate / 100);
			Balance += interestToPay;
		}
		
		public decimal InterestRate
		{
			get
			{
				return interestRate;
			}
			set
			{
				Logger.Log("SetInterestRate");
				//{
				//	throw new Exception();
				//}

				interestRate = value;
			}
		}


		//Clean Code Recommended Get Set Accessors
		//public void SetInterestRate(decimal newRate)
		//{
		//  Logger.Log("Interest Rate Set")
		//	interestRate = newRate;
		//}

		//public decimal GetInterestRate()
		//{
		//	return interestRate;
		//}


		//Short Form Property Declarations - can only use if the get & set have no internal steps
		//Other than accessing the backing field.
		public decimal Balance { get; private set; }


		public string AccountNumber { get; private set; }
		public List<AccountHolder> AccountHolders { get; private set; }


		private decimal interestRate;



    }
}
