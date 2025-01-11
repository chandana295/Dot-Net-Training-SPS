using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _15thQuestion
    {
        static void Main()
        {
            //Write a program in C# to accept ten marks and display the following
            //a.Total
            //c.Minimum marks
            //d.Maximum marks
            //e.Display marks in ascending order
            //f.Display marks in descending order
            int[] a = new int[10];
            Console.WriteLine("Enter marks of 10 ");
            for(int i=0;i<10;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            //sum
            int sum = 0;
            int min = a[0];
            int max = a[0];
            for(int i=0;i<10;i++)
            {
                sum += a[i];
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i]>max)
                {
                    max = a[i];
                }
                
         
            }
            Console.WriteLine();
            Console.WriteLine("Total marks = " + sum);
            //minimum number
            Console.WriteLine();
            Console.WriteLine("Minimum marks = " + min);
            //maximum number
            Console.WriteLine();
            Console.WriteLine("Maximum mark = " + max);
            Console.WriteLine();
            Console.WriteLine("Ascending order of given marks = ");
            for (int i = 0; i < a.Length - 1; i++) // Outer loop for passes
            {
                for (int j = 0; j < a.Length - 1 - i; j++) // Inner loop for comparisons
                {
                    if (a[j] > a[j + 1]) // Compare adjacent elements
                    {
                        // Swap if the current element is greater than the next
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }

            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

           Console.WriteLine();
           Console.WriteLine("Descending order of given marks = ");
           for(int i=10;i<=0;i--)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
