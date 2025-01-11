using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _4rthQuestion
    {
        static void Main()
        {
            //Accept a number from the user and display whether the given number is an odd number or even number.
            Console.WriteLine("Enter a number to check it is even or odd");
            int a=int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
