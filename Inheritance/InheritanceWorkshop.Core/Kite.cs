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
            get => _b; 
            set => _b = value;
        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimeter()
        {
            return base.GetPerimeter();
        }

        public Kite (double B)
        {
            Kite = Kite;
        }
    }
}
