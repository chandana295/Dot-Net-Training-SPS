namespace AssignmentOnLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var c = from i in num
                    let x=i*i*i
                    where x>100 && x<1000
                    select x;
            foreach(var k in c)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
        }
    }
}
