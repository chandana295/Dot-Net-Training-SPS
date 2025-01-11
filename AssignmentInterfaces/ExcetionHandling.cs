using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInterfaces
{
    internal class ExcetionHandling
    {
        static void Main()
        {
            try
            {
                byte a, b;
                Console.WriteLine("Enter a,b values");
                a = byte.Parse(Console.ReadLine());//Enter value more than 255
                b = byte.Parse(Console.ReadLine());
                int[] m = { 12, 24, 36 };
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(m[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Good Evening");
        }
    }
}
