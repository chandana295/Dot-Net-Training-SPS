using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClassesAndObjects
{
    internal class Account
    {
        public int acc_no;
        public string cust_name;
        public string acc_type;
        public string transaction_type;
        public double balance;
    }
    class Account_Repo
    {
        public Account[] list = new Account[5];
        int count = 0;
        public void  Accept(Account a)
        {
            if(count<list.Length)
            { list[count] = a;
              count++;
            }
            else
            {
                Console.WriteLine("The list is full!");
            }
            
        }
        public void Show()
        {
            foreach (Account b in list)
            {
                if (b != null)
                { 
                Console.WriteLine($"Account numer = {b.acc_no}{"\n"}Name of The Account Holder : {b.cust_name}{"\n"}Account Type : {b.acc_type}{"\n"}Balance : {b.balance}{"\n"}");
                Console.WriteLine();
            } }
        }
        public void Credit(int id,double balance)
        {
            foreach(Account b in list)

            {
                if (b != null)
                {
                    if (b.acc_no == id) ;
                    {
                        Console.WriteLine("The Amount Credited is : " + balance);
                        b.balance += balance;
                        Console.WriteLine("The balance after Credit Money is:" + b.balance);
                    }
                }
            }
        }
        public void Debit(int id,double balance)
        {
            foreach (Account b in list)

            {
                if (b != null)
                {
                    if (b.acc_no == id)
                    {
                        Console.WriteLine("The Amount debited is : " + balance);
                        b.balance -= balance;
                        Console.WriteLine("The balance after Debit Money is:" + b.balance);
                    }
                }
            }
        }
    }
    class Test
    {
        static void Main()
        {
            Account_Repo rr = new Account_Repo();
            do
            {
                Console.WriteLine("============================================");
                Console.WriteLine("1.Add Account Details\n2.Display all acocunts\n3.Debit\n4.Credit\n5.Exit");
                Console.WriteLine();
                Console.WriteLine("Enter Your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                           {
                            Account aa = new Account();
                            Console.Write("Enter the Account number : ");
                            aa.acc_no=int.Parse(Console.ReadLine());
                            Console.Write("Enter the Name of Account Holder : ");
                            aa.cust_name = Console.ReadLine();
                            Console.Write("Enter Account Type : ");
                            aa.acc_type = Console.ReadLine();
                            Console.Write("Enter the intital Deposit You Want : ");
                            aa.balance=double.Parse(Console.ReadLine());
                            rr.Accept(aa);
                            }
                            break;
                    case 2:
                        {
                            Console.WriteLine("The Details Of The Account are : ");
                            Console.WriteLine();
                            rr.Show();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter the Account for verification : ");
                            int id=int.Parse(Console.ReadLine());
                            Console.Write("Enter the Amount to be Debited : ");
                            double amt=int.Parse(Console.ReadLine());
                            rr.Debit(id,amt);
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Enter the Account for verification : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Amount to be Credited : ");
                            double amt = int.Parse(Console.ReadLine());
                            rr.Credit(id, amt);
                        }
                        break;
                    case 5:
                        {
                            Environment.Exit(0); //terminated the app
                        }
                        break;
                }

            } while (true);

        }


       } 
}
