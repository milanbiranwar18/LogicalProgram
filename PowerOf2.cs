using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PowerOf2
    {
        public static void PowerOfTwo()
        {
            int n = 31;
            int var = 1;

            for (int i = 1; i < n; i++)
            {
                var = var * 2;
                Console.WriteLine(var);
            }

           

        }
    }
}
