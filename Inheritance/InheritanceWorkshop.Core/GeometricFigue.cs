using System;

    
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

    public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name} => Area.....: {GetArea():N5}\tPerimeter: {GetPerimeter():N5}";
        }
    }


