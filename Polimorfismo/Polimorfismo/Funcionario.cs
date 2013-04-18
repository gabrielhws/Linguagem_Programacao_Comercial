using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Funcionario : Pessoa
    {
        // Recebe o mesmo salário de uma pessoa
        public override void Salario()
        {
            base.Salario();
        }
    }
}
