using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class RightTrianglePattern
    {
        static void Main()
        {
            //for(int i=6;i>0;i--)
            //{
            //    for(int j=0;j<i-1;j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("*");
            //    }


            int n = 6; // Define the number of rows

            for (int i = 1; i <= n; i++) // Outer loop for rows
            {
                // Inner loop for spaces
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                // Inner loop for stars
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line after printing stars and spaces for a row
                Console.WriteLine();
            }
        }
        }
    }

