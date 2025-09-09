using System;

    // Clase abstracta
    public abstract class GeometricFigure
    {
        // Propiedad
        public string Name
        { 
            get => Name; 
            set => Name = value;
        }

        // Métodos abstractos
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Método ToString sobrescrito
        public override string ToString()
        {
            return $"{Name} => Area.....: {GetArea():N5}\tPerimeter: {GetPerimeter():N5}";
        }
    }


