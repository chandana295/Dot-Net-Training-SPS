using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentClassesAndObjects;

namespace AssignmentClassesAndObjects
{
    abstract class Shape
    {
        public abstract void Area();
        public abstract double result { get; set; }

    }
    class Circle : Shape
    {
        int r = 0;
        public Circle(int r)
        {
            this.r = r;
        }
        public override double result { get; set; }
        public override void Area()
        {
            result = (Math.PI * r * r);
            Console.WriteLine("The are of the circle is " + result);
        }

    }
    class Square : Shape
    {
        int s;
        public override double result { get; set; }
        public Square(int s)
        {
            this.s = s;
        }
        public override void Area()
        {
            result = 4 *(Math.Pow(s,2));
            Console.WriteLine("The area of the Square is : "+result);
        }

    }
    class Rectangle : Shape
    {
        int l;
        int b;
        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override double result { get; set; }
        public override void Area()
        {
            result = 2 * (l + b);
            Console.WriteLine("The Area of the Rectangle is : " + result);
        }
    }
    class Triangle : Shape
    {
        int b, h;
        public Triangle(int b,int h)
        {
            this.b = b;
            this.h = h;
        }

        public override double result { get; set; }
        public override void Area()
        {
            result = 0.5 * b * h;
            Console.WriteLine("The Area of the Traingle : " + result);
        }
    }
   
     
      
        internal class Shapes
    {
        public static void Main()
        {
            Circle c = new Circle(4);
            c.Area();
            
            Square s=new Square(4);
            s.Area();

            Triangle t= new Triangle(4,4);
            t.Area();

            Rectangle r = new Rectangle(5, 10);
            r.Area();
        }
    }
}



