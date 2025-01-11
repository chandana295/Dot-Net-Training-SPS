using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace C_Assignment01
{
    internal class _13thQuestion
    {
        static void Main()
        {
            //Write a program in C# to find the largest of the given three numbers. Accept the numbers from the users.
            Console.WriteLine("Enter three numbers");
            int a =int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine());
            int x = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine();
            Console.WriteLine("greatest number is "+x);
        }
    }
}
