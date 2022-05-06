using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer3
{
    internal class Rectangulo : Forma
    {
        protected double lado1;
        protected double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public double Area()
        {
            return lado1 * lado2;
        }
        public double Perimetro()
        {
            return lado1 * 2 + lado2 * 2;
        }
        public override string ToString()
        {
            return ("El area del rectangulo es: " + Area() + "\n" + "El perimetro del rectangulo es: " + Perimetro());
        }
    }
}
