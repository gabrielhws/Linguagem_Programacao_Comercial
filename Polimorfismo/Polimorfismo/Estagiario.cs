using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Estagiario : Pessoa
    {
        // Recebe metade do valor do salário de uma Pessoa
        public override void Salario()
        {
            salario /= 2;
            base.Salario();
        }
    }
}
