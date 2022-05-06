using System;


namespace Challenge5Ejer3
{
    public class Circulo : Forma
    {
        protected double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radio,2);
        }
        public double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
        public override string ToString()
        {
            return ("El area del circulo es: " + Area() + "\n" + "El perimetro del circulo es: " + Perimetro());
        }

    }
}
