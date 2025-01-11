using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _6thQuestion
    {
        static void Main()
        {
            //Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
            Console.WriteLine("Enter the temperature in Fahrenheit");
            int f=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int c= ((f-32) *5 / 9);
            Console.WriteLine("The temparature in Celsius is " + c);
        }
    }
}
