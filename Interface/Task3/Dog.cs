using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Task3
{
	public class Dog : Animal, IPet
	{
		public string Name { get; set ; }
		public int Age { get; set; }
		public override void MakeNoise()
		{
            Console.WriteLine("woof woof");
        }
	}
}
