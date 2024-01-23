using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_HW
{
    internal class Square : Shape
    {
        public Square(double side) : base(side)
        {
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * side;
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
