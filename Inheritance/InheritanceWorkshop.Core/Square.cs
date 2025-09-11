using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Square : GeometricFigure
    {
        private double area;

        public Square(string name, double area) => A = area;
      
        public double A
        {
            get => area;
            set => area = ValidateA(value);
        }

        public override double GetArea() => A * A;

        public override double GetPerimeter() => 4 * A;

        private int ValidateA(double area)
        {
            if (area < 0)
            {
                throw new Exception($"The area {area} is not valid");
            }

            return (int)area;
        }

    }
}
