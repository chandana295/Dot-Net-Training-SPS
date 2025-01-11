using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassesAndObjects
{
    class Book
    {
        string cust_name;
        int book_no;
        string book_name;
        string book_author;
        int quantityofbooks;
        double book_amt;

        public Book(string cust_name, int book_no,string book_name,string book_author,int quantityofbooks,double book_amt)
        {
            this.book_no = book_no;
            this.book_name = book_name;
            this.book_author = book_author;
            this.quantityofbooks = quantityofbooks;
            this.book_amt = book_amt;
            this.cust_name= cust_name;
            
            

        }
        public void DisplayData()
        {
            Console.WriteLine($"The details of the custoomer {cust_name} are as below : ");
            Console.WriteLine("Book Id No : " + book_no);
            Console.WriteLine("Book name : " + book_name);
            Console.WriteLine("Book Author : " + book_author);
            Console.WriteLine("No.of books taken : " + quantityofbooks);
            Console.WriteLine();
        }
        public void DisplayBill()
        {
            Console.WriteLine("Amount : " + quantityofbooks*book_amt);
        }

    }
    internal class BookStore
    {
        static void Main()
        {
            Console.WriteLine("Enter the Customer name : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the no.of Books taken by the Customer");
            int n = int.Parse(Console.ReadLine());
            Book[] noofbooks = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Id no of the Book : ");
                int book_no = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the name of the book : ");
                string book_name = Console.ReadLine();

                Console.WriteLine("Enter the author of the book : ");
                string book_author = Console.ReadLine();

                Console.WriteLine("Enter the quantity of the books : ");
               int quantityofbooks = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the amount of the book : ");
                double book_amt = double.Parse(Console.ReadLine());


                noofbooks[i] = new Book(name,book_no, book_name, book_author, quantityofbooks, book_amt);

               
            }
            foreach(Book i in noofbooks)
            {
                Console.WriteLine();
                i.DisplayData();
                i.DisplayBill();
            }
            }
    }
}
