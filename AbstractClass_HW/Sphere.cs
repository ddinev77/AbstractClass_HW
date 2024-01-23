using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_HW
{
    internal class Sphere : Shape
    {
        public Sphere(double side) : base(side)
        {
        }

        public override double CalculateArea()
        {
            return 4 * Math.PI * side * side;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * side;
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
