using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOnConstructore
{
//    Create a class called building which has datamembers like
//string type(Flat/Villa)
//string capacity(2BHK/3BHK/4BHK)
//string dimension
//if flat store the floor number where the flat is available
//If villa store the land dimension like 20X30,60X40,30X40 as values
//string dateofcompletion
//Accept all values through constructor
//Display all values using showdata(). 
class Building
    {
        string type;
        string capacity;
        string dimension;
        string dateofCompletetion;
        public Building()
        {
            Console.WriteLine("Enter the Type of Building You Want \n 1.Flat \n 2.Villa");
            type = Console.ReadLine();
            Console.WriteLine("Enter the Capacity 2BHK/3BHK/4BHK");
            capacity= Console.ReadLine();
            Console.WriteLine("Enter the Dimension Like 20X30,60X40,30X40");
            dimension = Console.ReadLine();
            Console.WriteLine("Enter the Date of the Completion");
            dateofCompletetion = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("The Details entered are : ");
            Console.WriteLine($"Building Type : {type} , Capacity is : {capacity} , Dimesnions of the building is {dimension} , data of the Completion is {dateofCompletetion}");
        }
    }
    internal class _2ndQuestion
    {
        static void Main()
        {
            Building b = new Building();
            b.Display();
        }
       
        
    }
}
