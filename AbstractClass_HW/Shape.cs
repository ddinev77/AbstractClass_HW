using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_HW
{
    abstract class Shape
    {
        Random rnum = new Random();

        public int id;
        public double side;

        private protected Shape(double side)
        {
            this.id = rnum.Next(0, 101);
            this.side = side;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();


        public virtual void Print()
        {
            Console.WriteLine("Side: " + this.side);
            Console.WriteLine("The area is: " + this.CalculateArea());
            Console.WriteLine("The perimeter is: " + this.CalculatePerimeter());
        }

    }
}
