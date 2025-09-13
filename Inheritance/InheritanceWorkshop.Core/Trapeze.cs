using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d; set => _d = ValidateD(value);
        }

        public override double GetArea() => ((B + D)(H / 2));

        public override double GetPerimeter() => A + B + C + D;
        public Trapeze(double trapeze) => Trapeze = _d;

        private double ValidateD(double _d)
        {
            if (_d < 0)
            {
                throw new Exception($"The side {_d} is not valid");
            }
            return _d;
        }
    }
}
