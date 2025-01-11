using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class FindNumberInArray
    {
        static void Main()
        {
            int[] num = { 1, 2, 34, 45, 56, 67, 78, 89, 90, 00, 21, 43, 54, 65, 76, 87, 98, 98 };
            Console.WriteLine("No.of numbers present here are"+num.Length);
            Console.WriteLine("Enter any number to check the existence");
            int n=int.Parse(Console.ReadLine());
            string result = null;
            for(int i=0;i<num.Length;i++)
            {
                if (n == num[i])
                {
                    result = "You guessed it right";
                    break;
                }
                else
                    result = "you lost";

            }
            Console.WriteLine(result);
        }
    }
}
