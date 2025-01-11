using System.ComponentModel.DataAnnotations;

namespace AssignmentOnConstructore
{
    internal class Program
    {
        class Person
        {
            string FirstName;
            string LastName;
            string email;
            string dob;
            public Person()
            {
                Console.WriteLine("Enter the First name ");
                FirstName = Console.ReadLine();

                Console.WriteLine("Enter the Last name : ");
                LastName = Console.ReadLine();

                Console.WriteLine("Enter the email of the person : ");
                email = Console.ReadLine();

                Console.WriteLine("Enter the Date of Birth : ");
                dob = Console.ReadLine();

            }
            public void Display()
            {
                Console.WriteLine();
                Console.WriteLine($"The Name of the person is {FirstName} {LastName}");
                Console.WriteLine("Email : " + email);
                Console.WriteLine("Dob : " + dob);
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Display();
        }
    }
}
