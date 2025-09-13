using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Circle : GeometricFigure
    {
        private double _r;


        public Circle(string name, double _r)
        {
            R = _r;
        }

        public double R
        {
            get => _r; set => _r = ValidateR(value);
        }
        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
        private double ValidateR(double _r)
        {
            if (_r < 0)
            {
                throw new Exception($"The radius {_r} is not valid");
            }
            return _r;
        }
    }
}

