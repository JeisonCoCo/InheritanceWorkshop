using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Circle : GeometricFigure
    {
        private double r;
        public Circle(double r)
        {
            R = r;
        }
        public double R
        {
            get => r;
            set => r = ValidateR(value);
        }
        public double GetArea() => Math.PI * R * R;
        public double GetPerimeter() => 2 * Math.PI * R;
        private double ValidateR(double radius)
        {
            if (radius < 0)
            {
                throw new Exception($"The radius {radius} is not valid");
            }
            return radius;
        }
    }
}

