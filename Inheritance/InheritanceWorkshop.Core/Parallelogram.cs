using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H
        {
            get => _h; set => _h = ValidateH(value);
        }

        public override double GetArea() => B * H;

        public  double GetPerimeter() => 2 * (A + B);

        public Parallelogram() => Parallelogram = _h;

        private double ValidateH(double _h)
        {
            if (_h > 0)
            {
                throw new Exception($"The height {_h} is not valid");
            }
            return _h;
        }
    }
}
