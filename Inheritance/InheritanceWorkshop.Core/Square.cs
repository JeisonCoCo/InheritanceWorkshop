using Geometry;
using System;

namespace InheritanceWorkshop.Core
{
    public class Square : GeometricFigure
    {
        private double _a;

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public string A
        {
            get => A; set => A = ValidateA();
        }

        private int ValidateA(double value)
        {
            if (value < 0)
            {
                throw new Exception($"The minute {A} is not valid");
            }
            return value;
        }

    }
}
