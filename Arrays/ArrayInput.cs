using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class arrayinput
    {
        static void Main()
        {
            string[] s = new string[4];
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("Enter the city name:");
                s[i]=Console.ReadLine();
            }
            Console.WriteLine("Here is the list of cities you given");
            foreach(string i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}
