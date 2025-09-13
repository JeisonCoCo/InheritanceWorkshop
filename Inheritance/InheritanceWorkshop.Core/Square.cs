using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Square : GeometricFigure
    {
        private double _a;

        public Square(string name, double _a)
        {
            Name = name; 
            A = _a;
        }

        public double A
        {
            get => _a; set => _a = ValidateA(value);
        }

        public override double GetArea() => A * A;

        public override double GetPerimeter() => 4 * A;

        private int ValidateA(double _a)
        {
            if (_a < 0)
            {
                throw new Exception($"The area {_a} is not valid");
            }
            return _a;
        }

    }
}
