using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _5th_question
    {
        static void Main()
        {
            // Write a program in C# to find the total number of odd and even numbers accepted from the user.
            Console.WriteLine("Enter how many number you want to enter");
            int a=int.Parse(Console.ReadLine());
            int[] n = new int[a];
            int even = 0;
            int odd = 0;
            Console.WriteLine("Enter the numbers");
            for(int i=0;i<a;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int j=0;j<n.Length;j++)
            {
                if (n[j]%2==0)
                {
                    even++;
                }
                else
                    odd++;

            }
            Console.WriteLine("The no.of even number in the given input are" + even);
            Console.WriteLine("The no.of odd number in the given input are" + odd);

        }
    }
}
