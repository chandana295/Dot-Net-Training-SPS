using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassesAndObjects
{
    internal class Student
    {

        //rollno, name, class, SEM, branch, 
        //  int[] marks = new int marks[5] (marks of 5 subjects )
        int rollno;
        string name;
        string stud_class;
        int sem;
        string branch;
        int[] marks = new int[5];

        public Student(int rollno, string name, string stud_class, int sem, string branch, int[] marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.stud_class = stud_class;
            this.sem = sem;
            this.branch = branch;
            if (marks.Length == 5)
            {
                this.marks = marks;
            }
            else
            {
                Console.WriteLine("You must enter exactle 5 marks");
            }
        }
        public void Displayresult()
        {
            Console.WriteLine("This will display the average result");
            int total_marks = 0;
            string result = "Pass";
            foreach (int x in marks)
            {


                if (x < 35)
                {
                    result = "Fail";
                    break;
                }
                total_marks += x;
            }

            double Avg_marks = total_marks / 5.0;
            if (result == "Pass" & Avg_marks > 50)
            {
                Console.WriteLine("Average marks: " + Avg_marks);
            }
            else
            {
                Console.WriteLine("Result: " + result);
            }


        }
       
            public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll Number: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + stud_class);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Branch: " + branch);
            Console.Write("Marks: ");
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            Console.Write("How many studednt marks are you going to enter : ");
            int n=int.Parse(Console.ReadLine());
           Student[] students = new Student[5];
            
          

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the marks of the student {i + 1}");
                Console.WriteLine("Student Details:");
                Console.WriteLine("Roll Number: ");
                int rollno = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Class: ");
                string stud_class = Console.ReadLine();

                Console.WriteLine("Semester: ");
                int sem = int.Parse(Console.ReadLine());

                Console.WriteLine("Branch: ");
                string branch = Console.ReadLine();

                int[] marks = new int[5];
                Console.WriteLine("Enter marks for 5 subjects:");

                for (int j = 0; j < 5; j++)
                {
                    marks[j] = int.Parse(Console.ReadLine());
                }
                students[i] = new Student(rollno, name, stud_class, sem, branch, marks);
            }
            foreach(Student s in students)
            {

                Console.WriteLine("==================================================");
                s.DisplayData();
                Console.WriteLine();
                s.Displayresult();
            }
        }
    }
       
 }




