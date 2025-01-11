using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _9thQuestion
    {
        static void Main()
        {
            //Write a program in C# to generate a Fibonacci series till 40
            int n = 40;
            Console.WriteLine("The Fibnocci sequence upto 40 are");
            int a=0,b=10;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }

        }
    }
}
