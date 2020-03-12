using System;
using System.Collections.Generic;
using System.Text;

namespace _01ClassesHW
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
            {
            this.side1 = side1;
            this.side2 = side2;
            }

        double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        double PerimeterCalculator()
        {
            return (this.side1 + this.side2)*2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
