namespace AssignmentClassesAndObjects
{
    internal class Program
    {
        class Accounts
        {
            private int acc_no;
            private string cust_name;
            private string acc_type;
            private string transaction_type;
            private double balance;
        
            public double Credit(double amt)
            {
                balance += amt;
                return balance;
            }
            public double Debit(double amt)
            {
                balance -= amt;
                return balance;
            }
            public void Show()
            {
                Console.WriteLine($"Account number = {acc_no}{"\n"}Name = {cust_name} {"\n"}Account Type = {acc_type} {"\n"}Balance = {balance}");
            }
            public void Accept()
            {
                Console.WriteLine("Please Enter the details");
                Console.WriteLine("Your Account number");
                int acc_no=int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Your Account type{"\n"}Saving account {"\n"}Balancing Account {"\n"}Salary Account {"\n"}Deposit Account");
                string acc_type = Console.ReadLine();
                Console.WriteLine("Enter your Name : ");
                String cust_name=Console.ReadLine();
                Console.WriteLine("Enter the intial Balance ");
                int balance=int.Parse(Console.ReadLine());
                this.acc_no = acc_no;
                this.cust_name = cust_name;
                this.acc_type = acc_type;
                this.balance = balance;
            }
        }
        static void Main()
        {
            Accounts a1=new Accounts();
          
            a1.Accept();
            a1.Show();
            Console.WriteLine(a1.Credit(100));
            Console.WriteLine(a1.Debit(100));
        }
    }
}
