using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class JaggedArrayCreation
    {
        static void Main()
        {
            int[][] jarray = new int[3][];
            //1st index
            jarray[0] = new int[3] { 100, 200, 300 };
            jarray[1] = new int[2] { 3, 2 };
            jarray[2] = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine(jarray[0][0]);
            foreach (int i in jarray[2])
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int j=0;j<3;j++)
            {
                foreach (int k in jarray[j])
                {
                    Console.Write(k+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
