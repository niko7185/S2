using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public abstract class Shape
    {

        protected int x;
        protected int y;

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

        public Shape(int x, int y)
        {

            X = x;

            Y = y;

        }

        public abstract double CalculateArea();

        public abstract double CalculateCircumference();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
