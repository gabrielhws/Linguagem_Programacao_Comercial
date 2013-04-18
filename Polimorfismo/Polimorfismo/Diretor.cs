using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Diretor : Pessoa
    {
        // Recebe 10x mais que uma pessoa
        public override void Salario()
        {
            salario *= 10;
            base.Salario();
        }

    }
}
