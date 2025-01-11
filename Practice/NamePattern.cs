using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class NamePattern
    {
        static void Main()
        {
            string name;
            Console.WriteLine("Enter the name for pattern");
            name = Console.ReadLine();

            int n = name.Length;
            for (int i = n; i >0; i--)
            {
                Console.WriteLine(name.Substring(0, i));
            }
            Console.WriteLine();
        }
    }
}
