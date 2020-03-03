using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Square : Rectangle
    {

        //Erklær constructor
        public Square(int x, int y, double length) : base(x, y, length, length)
        {

        }

        //Override ToString metoden til at returnere alt information om denne kvadrat
        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"{base.ToString()}, Length: {Length}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
