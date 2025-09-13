using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Rhombus : Square
    {
        private double _d1, _d2;

        public double D1
        {
            get => _d1; set => _d1 = ValidateD1(value);
        }
        public double D2 
        { 
            get => _d2; set => _d2 = ValidateD2(value); 
        }

        public override double GetArea() => (D1 * D2)/2;

        public override double GetPerimeter() => 4 * A;

        public Rhombus(string name, double a, double _d1, double _d2) : base(name, a)
        {
            D1 = _d1;
            D2 = _d2;
        }

        private double ValidateD1(double _d1)
        {
            if (_d1 < 0)
            {
                throw new Exception($"The diagonal {_d1} is not valid");
            }
            return _d1;
        }

        private double ValidateD2(double _d2)
        {
            if (_d2 < 0)
            {
                throw new Exception($"The diagonal {_d2} is not valid");
            }
            return _d2;
        }
    }
}
