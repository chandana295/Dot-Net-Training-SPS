namespace AssignmentInterfaces
{
    internal class Program
    {
        interface IGovtRules
        {
            public double emp_pf(double basic_salary);
            public void LeaveDetails();
            public void GratuityAmount(float SericeCompleted, double BasicSalary);
        }
        public class TCS:IGovtRules
        {
            int emp_id;
            string name;
            string dept;
            string designation;
            double basic_salary;

            public TCS(int emp_id, string name, string dept,string designation, double basic_salary)
            {
                this.emp_id=emp_id;
                this.name= name;
                this.dept= dept;
                this.designation= designation;
                this.basic_salary= basic_salary;

            }
            public double emp_pf(double basic_salary)
            {
               double PF=(basic_salary*0.12);
                Console.WriteLine("PF money = " + PF);
                basic_salary -= PF;

                double emp_contirbution;
                emp_contirbution =(basic_salary * 0.0833);
                Console.WriteLine("Employee Contribution = " +emp_contirbution);
                basic_salary -= emp_contirbution;

                double Pension = basic_salary * 0.0367;
                Console.WriteLine("Pension Amount = " + Pension);
                basic_salary-= Pension;
                return basic_salary;
            }
            public void LeaveDetails()
            {
                Console.WriteLine("1 day of Casual Leave per month \n12 days of Sick Leave per year \n10 days of Previlage Leave per year ");
            }

            public void GratuityAmount(float SericeCompleted, double BasicSalary)
            {
                double gratuity_amt=0;
                if (SericeCompleted > 5)
                {
                    gratuity_amt = BasicSalary;
                }
                
                else if(SericeCompleted>10)
                {
                    gratuity_amt= 2*BasicSalary;
                }
                else if(SericeCompleted>20)
                {
                    gratuity_amt = 3*BasicSalary;
                }
                else
                {
                     Console.WriteLine("You have not yet completed 5yrs in our company so no gatiuity money");
                }
                Console.WriteLine($"The Gratuity Amount ="+ gratuity_amt);

                
            }
        }
        public class Accenture: IGovtRules
        {
            int emp_id;
            string name;
            string dept;
            string designation;
            double basic_salary;
            public Accenture(int emp_id, string name, string dept, string designation, double basic_salary)
            {
                this.emp_id = emp_id;
                this.name = name;
                this.dept = dept;
                this.designation = designation;
                this.basic_salary = basic_salary;

            }
            public double emp_pf(double basic_salary)
            {
                double PF = (basic_salary * 0.12);
                Console.WriteLine("PF money = " + PF);
                basic_salary -= PF;

                double emp_contirbution;
                emp_contirbution = (basic_salary * 0.12);
                Console.WriteLine("Employee Contribution = " + emp_contirbution);
                basic_salary -= emp_contirbution;

                return basic_salary;
            }
            public void LeaveDetails()
            {
                Console.WriteLine("2 day of Casual Leave per month \r\n5 days of Sick Leave per year \r\n5 days of Previlage Leave per year");
            }
            public void GratuityAmount(float SericeCompleted, double BasicSalary)
            {
                //Not implementing this method
            }

        }
        static void Main()
        {
            TCS tcs = new TCS(1,"chandana","R&D","designation",50000);
            Console.WriteLine();
            tcs.emp_pf(50000);
            tcs.LeaveDetails();
            tcs.GratuityAmount(20, 50000);

            Accenture acc = new Accenture(2,"Naruto","R&D","Hokage",1000000);
            Console.WriteLine();
            acc.emp_pf(1000000);
            acc.LeaveDetails();
        }
    }
}
