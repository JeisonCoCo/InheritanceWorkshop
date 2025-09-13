using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Kite : Rhombus
    {
        private double _b;

     public double B
        {
            get => _b; set => _b = ValidateB(value);
        }

        public override double GetArea() => (D1 * D2) / 2;
        
        public override double GetPerimeter() => 2 * (A + B);

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = ValidateB(b);
        }

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
