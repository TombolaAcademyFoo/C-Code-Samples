using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBank
{
	public class MortgageAccount :  CurrentAccount
	{

		public MortgageAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
		{
			
		}
	}
}
