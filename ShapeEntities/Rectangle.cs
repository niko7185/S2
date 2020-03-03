using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Rectangle : Shape
    {

        //Erklær fields
        private double length;
        private double width;

        //Erklær properties
        public double Length
        {
            get => length;

            set
            {

                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Length), "Length must be more than 0");

                length = value;
            }
        }

        public double Width
        {
            get => width;

            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Width), "Width must be more than 0");

                width = value;
            }
        }

        //Erklær constructor
        public Rectangle(int x, int y, double length, double width) : base(x, y)
        {

            Length = length;

            Width = width;

        }

        public override double CalculateArea()//Udregn areal af rektangel
        {

            return width * length; 

        }

        public override double CalculateCircumference()//Udregn omkreds af rektangel
        {

            return 2 * (width + length);

        }

        //Override ToString metoden til at returnere alt information om denne rektangel
        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"Position: ({X},{Y}), Length: {Length}, Width: {Width}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
