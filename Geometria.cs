using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Geometria
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }
        public double CalcularArea(double @base, double altura)
        {
            return @base * altura;
        }
        public double CalcularArea(double raio, bool isCirculo)
        {
            return Math.PI * raio * raio;
        }
    }
}
