﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicalProgram
{
    class FlipCoin
    {
        public static void Flip_Coin()
        {

            int headCount = 0;
            int tailcount = 0;

            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("Please enter the number of Flips");
            int filps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < filps; i++)
            {
                Random obj = new Random();

                int num = obj.Next(2);

                Console.WriteLine("The random number from system   --- " + num);

                if (num == 0)
                {
                    Console.WriteLine("Tail");
                    tailcount = tailcount + 1;
                }
                else if (num == 1)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }

            }

            headpercentage = (headCount * 100) / filps;

            tailpercentage = (tailcount * 100) / filps;

            Console.WriteLine("HeadPercentage ---- " + headpercentage);

            Console.WriteLine("TailPercentage ---- " + tailpercentage);



        }
    }
}
