using System;

namespace AssignmentOnInterfaces
{
    internal class Program
    {
        class Furniture
        {
            public int order_id;
            public DateTime order_date;
            public string furniture_type;
            public int quantity;
            public double total_amt;
            public string payment_mode;
            public string chairtype;
            public string purpose;
            public string subtype;
            public double rate;
            public void GetData()
            {
                Console.WriteLine("Enter the order id ");
                order_id=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the order Date (DD-MM-YY)");
                order_date = DateTime.Parse(Console.ReadLine());

            }
            public virtual void ShowData()
            {
                Console.WriteLine($"The Customer of order id {order_id} want the {furniture_type} of {subtype} and it costs around {rate}");
            }
        }
        class Chair : Furniture
        {
            

            public Chair()
                
            {
                base.GetData();
               

                Console.WriteLine("Enter the chair type \n1.Wood \n2.Steel\n3.Plastic");
                chairtype = Console.ReadLine();

                Console.WriteLine("What is the purpose of the chair");
                purpose = Console.ReadLine();
                if (chairtype.Equals("Wood", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the type of Wood\n1.Teak Wood\n2.Rose Wood");
                    subtype = Console.ReadLine();
                    rate=subtype.Equals("Teak Wood",StringComparison.OrdinalIgnoreCase)?2500:3000;
                }
                else if(chairtype.Equals("Steel",StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the type of Steel\n1.Gray Steel\n2.Green Steel\n3.Brown Steel");
                    
                    subtype = Console.ReadLine();
                    rate = 1500;
                }
                else if(chairtype.Equals("Plastic",StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is color of the plastic\n1.Green\n2.Blue\n3.White");
                   
                    subtype = Console.ReadLine();
                    rate = 2000;
                }
                else { Console.WriteLine($"There is not {chairtype} available.\nThnak! you"); }

                base.ShowData();
            }

        }
       class  Cot:Furniture
        {
            public Cot()
            {
                base.GetData();
                Console.WriteLine("Enter the COt type\n1.Wood\n2.Steel");
                chairtype=Console.ReadLine();
                if (chairtype.Equals("Wood",StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the type of Wood\n1.Teak Wood\n2.Rose Wood");
                    subtype = Console.ReadLine();
                    rate = subtype.Equals("Teak Wood", StringComparison.OrdinalIgnoreCase) ? 2500 : 3000;
                }
                else if(chairtype.Equals("Steel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the type of Steel\n1.Gay Steel\n2.Green Steel\n3.Brown Steel");

                    subtype = Console.ReadLine();
                    rate = 1500;
                }
                else if (chairtype.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is color of the plastic\n1.Green\n2.Blue\n3.White");

                    subtype = Console.ReadLine();
                    rate = 2000;
                }
                else { Console.WriteLine($"There is not {chairtype} available.\nThnak! you"); }

                base.ShowData();

            }
            
        }
        static void Main(string[] args)
        {
            string furniture_type;
            Console.WriteLine("Enter the Furnitur Type : ");
            furniture_type = Console.ReadLine();
            Furniture f = null;
            if (furniture_type.Equals("Chair", StringComparison.OrdinalIgnoreCase))
            {
               f=new Chair();
            }
            else if(furniture_type.Equals("Cot", StringComparison.OrdinalIgnoreCase))
            {
                f = new Cot();
            }
            else
            {
                Console.WriteLine("There is no product of your need with us");
            }
        }
    }
}
