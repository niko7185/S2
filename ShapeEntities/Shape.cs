using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public abstract class Shape
    {

        //Erklær fields
        protected int x;
        protected int y;

        //Erklær properties
        public int X
        {
            get => x;

            set
            {

                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(X), "X must be over 0");

                x = value;
            }
        }

        public int Y
        {
            get => y;

            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Y), "Y must be over 0");

                y = value;
            }
        }

        //Erklær constructor
        protected Shape(int x, int y)
        {

            X = x;

            Y = y;

        }

        //Erklær absract metoder
        public abstract double CalculateArea();

        public abstract double CalculateCircumference();

        //Override ToString metoden til at returnere x og y
        public override string ToString()
        {
            return $"Position: ({X},{Y})";
        }
    }
}
