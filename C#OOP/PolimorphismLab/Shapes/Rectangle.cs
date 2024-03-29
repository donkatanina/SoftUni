﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }
        public override double CalculateArea()
        {
           return height*width;
        }

        public override double CalculatePerimeter()
        {
            return 2*height + 2*width; ;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
