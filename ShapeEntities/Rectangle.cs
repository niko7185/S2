using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Rectangle : Shape
    {

        private double length;
        private double width;

        public double Length
        {
            get => length;

            set
            {
                length = value;
            }
        }

        public double Width
        {
            get => width;

            set
            {
                width = value;
            }
        }

        public Rectangle(int x, int y, double length, double width) : base(x, y)
        {

            Length = length;

            Width = width;

        }

        public override double CalculateArea()
        {

            return width * length; 

        }

        public override double CalculateCircumference()
        {

            return 2 * (width + length);

        }

        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"Position: ({X},{Y}), Length: {Length}, Width: {Width}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
