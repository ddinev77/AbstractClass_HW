﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AbstractClass_HW
{
    internal class Circle : Shape
    {
        public Circle(double side) : base(side)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * this.side * this.side;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.side;
        }

        public override void Print()
        {
            Console.WriteLine("Shape: Circle");
            base.Print();       
        }
    }
}
