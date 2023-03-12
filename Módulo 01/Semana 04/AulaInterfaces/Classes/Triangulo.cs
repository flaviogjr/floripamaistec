namespace AulaInterfaces.Classes
{
    public class Triangulo : IFigurasGeometricas
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double  Base { get; set; }

        public double Altura { get; set; }

        public double Area()
        {
            return  Base * Altura / 2;
        }

        public double Perimetro()
        {
            return LadoA + LadoB + Base;
        }
    }
}
