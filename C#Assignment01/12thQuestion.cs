using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _12thQuestion
    {
        static void Main()
        {
            //Write a program to print the numbers divisible by 7 between 200 and 300
            Console.WriteLine("The Numbers that are divisble by  7 are ");
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
