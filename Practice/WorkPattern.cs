using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class WorkPattern
    {
        static void Main()
        {
            string name = "chandana";
            for(int i=1;i<=name.Length;i++)
            {
                for(int j=9-i;j>0;j--)
                {
                    
                    Console.Write("*");


                }
                Console.WriteLine();

            }
        }
    }
}
