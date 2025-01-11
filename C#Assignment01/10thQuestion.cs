using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _10thQuestion
    {
        static void Main()
        {
            //Write a program that asks the user to type an integer N and computes the sum of the cubes
            Console.WriteLine("enter a number to find it's ");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine();
            for(int i=1;i<=n;i++)
            {
                sum += i * i * i;
            }
            Console.WriteLine("The cube of the number entered is "+sum);
        }
    }
}
