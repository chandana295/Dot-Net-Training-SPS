using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Pattern_manikanta
    {
        static void Main()
        {
            for(int i=1;i<5;i++)
            {
                for (int k = 1; k<i; k++)
                {
                    Console.Write(" ");
                }

                for (int j=6-i;j>0;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
               
            }
        }
    }
}
//54321
// 4321
//  321
//   21
//    1
