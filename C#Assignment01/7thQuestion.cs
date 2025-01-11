using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _7thQuestion
    {
        static void Main()
        {
            //Write a program to print the series: 0,1,4,9,16,.....625
            int i= 25;
            int x = 1;
            while(x<=i)
            {
                Console.Write(x * x + "\t");
                x++;
            }
        }
    }
}
