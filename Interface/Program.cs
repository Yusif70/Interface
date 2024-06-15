using Interface.Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region task4

			//BankAccount bankAccount = new BankAccount(100.50);

			//Console.WriteLine($"current balance is {bankAccount.Balance}");
			//Console.WriteLine("1) Deposit Money");
			//Console.WriteLine("2) Withdraw Money");
			//Console.WriteLine("3) Exit menu");
			//while (true)
			//{
			//	Console.Write("please select the number of operation: ");
			//	int operation = int.Parse(Console.ReadLine());
			//	if (operation == 1)
			//	{
			//		Console.Write("enter the amount to deposit: ");
			//		double amount = double.Parse(Console.ReadLine());
			//		bankAccount.Deposit(amount);
			//	}
			//	else if(operation == 2) 
			//	{
			//		Console.Write("enter the amount to withdraw: ");
			//		double amount = double.Parse(Console.ReadLine());
			//		bankAccount.Withdraw(amount);
			//	}
			//	else
			//	{
			//		Console.WriteLine("bye");
			//		break;
			//  }
			//}

			#endregion

			#region anagram words

			Console.WriteLine("enter two words: ");
			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();

			IsAnagram(s1, s2);

			#endregion
        }
		#region bonus

		#region anagram
		static void IsAnagram(string s1, string s2)
		{
			string sortedS1 = SortString(s1);
			string sortedS2 = SortString(s2);
			Console.WriteLine(sortedS1 == sortedS2 ? "words are anagram" : "words are not anagram");
        }
		static string SortString(string s1)
		{
			char[] charArray = s1.ToCharArray(); 
			for (int i = 0; i < charArray.Length - 1; i++)
			{
				for (int j = i + 1; j < charArray.Length; j++)  
				{
					if ((int)charArray[i] > (int)charArray[j])
					{
						char temp = charArray[i]; 
						charArray[i] = charArray[j]; 
						charArray[j] = temp; 
					}
				}
			}
			string sortedString = "";
			foreach (char c in charArray)
			{
				sortedString += c;
			}
			return sortedString;
		}
		#endregion

		#region power
		static int FindPower(int Base, int Exponent)
		{
			int num = 1;
			for(int i = 0; i < Exponent; i++)
			{
				num *= Base;
			}

			return num;
		}
		#endregion

		#endregion
	}
}