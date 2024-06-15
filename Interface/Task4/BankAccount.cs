using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Task4
{
	public class BankAccount : IAccount
	{
		public double Balance { get; set; }
        public BankAccount(double balance)
        {
            this.Balance = balance;
        }
        public void Deposit(double amount)
		{
            this.Balance += amount;
            Console.WriteLine($"new balance: {Balance}");
        }
		public void Withdraw(double amount)
		{
            if(this.Balance < amount)
            {
                Console.WriteLine("there is not enough money in balance");
            }
            else
            {
				this.Balance -= amount;
				Console.WriteLine($"new balance: {Balance}");
            }
        }
	}
}
