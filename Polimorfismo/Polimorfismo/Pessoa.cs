using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pessoa
    {
        protected double salario = 500;
        
        public virtual void Salario() 
        {
            ImprimiSalario(salario);
        }

        public void ImprimiSalario(double salario)
        {
            Console.WriteLine("Seu salário é: " + salario);
        }

    }
}
