using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _3rdquestion
    {
        static void Main()
        {
            //Write a program in C# to accept two numbers as command line argument and display all the
            // numbers between the given two numbers.
            Console.WriteLine("Enter two number to print all the number between the range");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            
            for(int x=a; x<b;x++)
            {
                Console.Write(x+"\t");
            }
        }
    }
}
