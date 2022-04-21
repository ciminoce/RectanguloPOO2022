namespace RectanguloPOO2022.Entidades
{
    public class Rectangulo
    {
        public int LadoMayor { get; set; }
        public int LadoMenor { get; set; }

        public Rectangulo()
        {
            
        }

        public Rectangulo(int ladoMayor, int ladoMenor)
        {
            this.LadoMayor = ladoMayor;
            this.LadoMenor = ladoMenor;
        }

        public bool Validar()
        {
            return LadoMayor > 0 && LadoMenor > 0 && LadoMayor > LadoMenor;
        }

        public double GetPerimetro() => 2 * LadoMayor + 2 * LadoMenor;
        public double GetSuperficie() => LadoMenor * LadoMayor;
    }
}
