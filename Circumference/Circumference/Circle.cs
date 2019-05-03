using System;
using System.Collections.Generic;
using System.Text;

namespace Circumference
{
    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * _radius;
        }

        public string CalculateFormattedCircumference()
        {
            return string.Format(@"Circumference: {0}", 
                FormatNumber(CalculateCircumference()));
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public string CalculateFormattedArea()
        {
            return string.Format(@"Area: {0}", FormatNumber(CalculateArea()));
        }

        private string FormatNumber(double number)
        {
            return string.Format(@"{0:N2}", number);
        }

        public double GetRadius()
        {
            return _radius;
        }
    }
}
