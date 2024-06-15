using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Task2
{
	public class SimpleCalculator : ICalculator
	{
		public double Add(double a, double b)
		{
			return a + b;
		}
		public double Subtract(double a, double b)
		{
			return a - b;
		}
		public double Multiply(double a, double b)
		{
			return a * b;
		}
		public double Divide(double a, double b)
		{
			return a / b;
		}

	}
}
