namespace InheritanceWorkshop.Core
{

    public abstract class GeometricFigure
    {
        //Properties
        public string Name { get; set; }

        //Methods
        /*protected GeometricFigure(string Name) //solo puede ser usado por las clases hijas de GeometricFigure
        {
            this.Name = Name;
        }  */
        public abstract double GetArea(); //metodo abstracto, no tiene cuerpo, las clases hijas deben implementarlo
        public abstract double GetPerimeter(); //metodo abstracto, no tiene cuerpo, las clases hijas deben implementarlo
        public override string ToString()
        {
            return $"{ Name } => Area.....: {GetArea().ToString("N5"),10}\tPerimeter: {GetPerimeter().ToString("N5"),10}";
        }
    }
}
