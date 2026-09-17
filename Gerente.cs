using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gerente : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.15 + 1000;
        }
    }
}
