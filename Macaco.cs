using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Macaco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Ugh ugh aah aah!");
        }
    }
}