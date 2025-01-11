namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of array
            int[] n = new int[5];
            n[0] = 10;
            n[1] = 60;
            n[2] = 20;
            n[3] = 30;
            n[4] = 40;
            Console.WriteLine(n[4]);
            //printing the array values
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(n[i]);
            }
            //printing using for each
            Console.WriteLine("Printing array values using for each");
            foreach(int j in n)
            {
                Console.WriteLine(j);
            }
        }
    }
}
