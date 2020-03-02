using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Circle : Shape
    {

        private double radius;

        public double Radius
        {
            get => radius;

            set
            {
                radius = value;
            }
        }

        public Circle(int x, int y, double radius) : base(x, y)
        {

        }

    }
}
