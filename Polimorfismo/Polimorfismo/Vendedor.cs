using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Vendedor : Pessoa
    {
        // Recebe 5x mais que uma pessoa mais 5%
        public override void Salario()
        {
            salario = (salario * 5) * 1.05;
            base.Salario();
        }

    }
}
