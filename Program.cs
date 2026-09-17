using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main()
        {
            Geometria geometria = new Geometria();
            Console.WriteLine(
                $"Área do quadrado: {geometria.CalcularArea(4):F2}");

            Console.WriteLine(
                $"Área do retângulo: {geometria.CalcularArea(5, 3):F2}");

            Console.WriteLine(
                $"Área do círculo: {geometria.CalcularArea(2, true):F2}");
        }
    }
}
