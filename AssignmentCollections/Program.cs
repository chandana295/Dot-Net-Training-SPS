
using System.Collections.Generic;
namespace AssignmentCollections
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num); // Add the number to the list
               

                Console.WriteLine("\n Numbers in ascending Order");
               
            }
            numbers.Sort();


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
                    
            

        }
    }
}
