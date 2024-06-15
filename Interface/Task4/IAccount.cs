using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Task4
{
	public interface IAccount
	{
		double Balance { get; set; }
		void Deposit(double amount);
		void Withdraw(double amount);
	}
}
