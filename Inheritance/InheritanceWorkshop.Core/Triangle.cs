using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c; set => _c = ValidateC(value);
        }
        public double H
        {
            get => _h; set => _h = ValidateH(value);
        }

        public override double GetArea() => (B * H) * 2;

        public override double GetPerimeter() => A + B + C;

        public Triangle(double triangle) => Triangle = _c;

        private double ValidateC(double _c)
        {
            if (_c < 0)
            {
                throw new Exception($"The side {_c} is not valid");
            }
            return _c;
        }

        private double ValidateH(double _h)
        {
            if (_h < 0)
            {
                throw new Exception($"The height {_h} is not valid");
            }
            return _h;
        }
    }
}
