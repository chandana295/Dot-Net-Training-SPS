using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollections
{
    internal class _2ndQuestion
    {
        static void Main()
        {
            List<string> name = new List<string>();

            Console.WriteLine("Enter 10 names:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                string n = Console.ReadLine();
                name.Add(n);
            }
            name.Sort();
            foreach (string x in name)
            {
                Console.WriteLine(x);
            }
        }
    }
}
