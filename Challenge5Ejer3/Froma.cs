using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer3
{
    public class Froma
    {
      public Ubicacion c { get; set; }

        public virtual string ToString()
        {
            return c.ToString();
        }
        public virtual double Area()
        {
            double area = 0;
            return area;
        }
        public virtual double Perimetro()
        {
            double perimetro = 0;
            return perimetro;
        }

    }
}
