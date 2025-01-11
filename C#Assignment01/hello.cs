using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment01
{
    class a
    {
        public int add(int x, int y)
        {
            return x + y;
           
        }
    }
    internal class hello
    {
            static void Main()
            {
                a obj = new a();
            int x = obj.add(1, 2);
                Console.WriteLine(x);
        }
    }
}
