using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(4);
            Console.WriteLine(circulo.ToString());
            Console.WriteLine();

            Rectangulo rectangulo = new Rectangulo(4, 5);
            Console.WriteLine(rectangulo.ToString());
            Console.ReadKey();



        }
    }
}
