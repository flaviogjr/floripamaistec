namespace AulaInterfaces.Classes
{
    public class Quadrado : IFigurasGeometricas
    {
        public double TamanhoLado { get; set; }
        public double Area()
        {
            return TamanhoLado * TamanhoLado;
        }

        public double Perimetro()
        {
            return TamanhoLado * 4;
        }

    }
}
