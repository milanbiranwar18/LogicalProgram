using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class HarmonicNumber
    {
		public static void harmonicNumber()
		{
			double num = 0;
			int i;
			Console.Write("Enter the Number: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (i = 1; i <= n; i++)
			{
				Console.WriteLine("1/{0}", +i);
				num = num + (1 / (float)i);

			}
			Console.Write("Sum of Series upto{0} terms : {1} ", n, num);
			Console.ReadLine();
		}


	}
}
