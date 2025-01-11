using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassesAndObjects
{
    class Student6th
    {
        int rollno;
        string stud_name;
        int MarksInEnglish;
        int MarksInScience;
        public  Student6th(int rollno, string stud_name,int marksInEnglish, int marksInScience)
        {
            this.rollno = rollno;
            this.stud_name = stud_name;
            this.MarksInEnglish = marksInEnglish;
            this.MarksInScience = marksInScience;    
        }
        public void Display()
        {
            Console.WriteLine("The Student Name is : " + stud_name);
            Console.WriteLine("Roll no : "+rollno);
            Console.WriteLine("Marks in English : "+MarksInEnglish);
            Console.WriteLine("Marks in Science : " + MarksInScience);
        }
        public void TotalMarks()
        {
            Console.WriteLine("totale Marks= " + (MarksInEnglish + MarksInScience));
        }
        public void Percentage()
        {
            double result=MarksInScience + MarksInEnglish;
            Console.WriteLine(result.ToString("P", CultureInfo.InvariantCulture));
        }
    }
    internal class _6thQuestion
    {
        static void Main()
        {
            Student6th ss = new Student6th(0295,"Chandana",70,80);
            ss.Display();
            ss.TotalMarks();

        }
    }
}
