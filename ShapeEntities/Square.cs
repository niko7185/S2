using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Square : Rectangle
    {

        public Square(int x, int y, double length) : base(x, y, length, length)
        {

        }

        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"Position: ({X},{Y}), Length: {Length}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
