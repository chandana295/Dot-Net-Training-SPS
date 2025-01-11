using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    internal class _11thQuestion
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to print the table");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<=20;i++)
            {

                Console.WriteLine($"{n} * {i} = {n*i}");
            }
            Console.WriteLine("==================");
        }
    }
}
