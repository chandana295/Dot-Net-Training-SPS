using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    class A
    {
        public void sum()
        {
            Console.WriteLine("This is Class A");
        }
    }
    internal class _2ndquestion
    {
       
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("Hi!, "+name);
            Console.WriteLine("Welcome to the world of c#");
            A obj = new A();
            A.sum();
        }
    }
}
