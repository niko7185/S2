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

        public override double CalculateArea()
        {

            return (radius * radius) * 3.14;

        }

        public override double CalculateCircumference()
        {

            return 3.14 * (radius * 2);

        }

        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"Position: ({X},{Y}), Radius: {radius}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
