using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Circle : Shape
    {

        //Erklær field
        protected double radius;

        //Erklær property
        public double Radius
        {
            get => radius;

            set
            {

                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Radius must be more than 0");

                radius = value;
            }
        }

        //Erklær constructor
        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double CalculateArea()//Udregn areal af cirkel
        {

            return (radius * radius) * 3.14;

        }

        public override double CalculateCircumference()//Udregn omkreds af cirkel
        {

            return 3.14 * (radius * 2);

        }

        //Override ToString metoden til at returnere alt information om denne cirkel
        public override string ToString()
        {

            double area = CalculateArea();

            double cir = CalculateCircumference();

            return $"{base.ToString()}, Radius: {radius}.\nArea: {area}, Circumference: {cir}.\n";
        }

    }
}
