using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _8thQuestion
    {
        static void Main()
        {
            //. Write a program in C# to find the factorial of the given number
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The fatorial of given number is" + result);



        }
    }
}
