using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _14thQuestion
    {
        static void Main()
        {
            //Write a program in C# to find the smallest of five numbers accepted from the user.
            Console.WriteLine("Enter 5 number");
            int[] a = new int[5];
            
            for(int i=0;i<5;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            int s = a[0];
            for (int i=0;i<5;i++)
            {
                if (a[i]<s)
                {
                    s = a[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("The smallest number is " + s);
        }
    }
}
