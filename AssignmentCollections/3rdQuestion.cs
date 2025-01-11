using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCollections
{
        //    Write an executable program in C# that will hold the employee code and employee names 
        //available in an Organization using Collections.When the data is displayed it should be in a sorted
        //manner.Choose an appropiate type of Collection.
    internal class _3rdQuestion
    {
        static void Main()
        {
            Dictionary<int,string> employee=new Dictionary<int, string>();
            Console.WriteLine("Enter the no.of employees you want to enter");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Enter the Employee{i+1} id : ");
                int key=int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the name of the employee{i+1}: ");
                string value = Console.ReadLine();

                employee.Add(key, value);
            }
            var sortedByKey = employee.OrderBy(pair => pair.Key);
            foreach (var k in sortedByKey)
            {
                Console.WriteLine($"The employee ID is : {k.Key}\n and the name is : {k.Value}");
            }
        }
    }
}
