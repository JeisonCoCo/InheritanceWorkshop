using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b; set => _b = ValidateB(value);
        }
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
        public Rectangle(double rectangle) => Rectangle = rectangle;
        private double ValidateB(double _b)
        {
            if (_b < 0)
            {
                throw new Exception($"The side {_b} is not valid");
            }
            return _b;
        }
    }
}