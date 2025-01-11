using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MultiDimensionalArray
    {
        static void Main()
        {
            //first 3 is the row size and the secon d3 is the column size
            int[,] m = new int[3, 4];
            m[0,0]= 10;
            m[0,1]=20;
            m[0,2]=30;
            m[0,3]=40;
            //2nd row
            m[1,0]=11;
            m[1,1]=12;
            m[1,2]=13;
            m[1,3]=14;
            //3rs row
            m[2,0]=21;
            m[2,1]=22;
            m[2,2]=23;
            m[2,3]=24;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.Write(m[i,j]+"\t");
                }
                Console.Write('\n');
            }

        }
    }
}
