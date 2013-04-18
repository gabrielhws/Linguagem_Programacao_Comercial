using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args) {
            Pessoa p = new Pessoa();
            IrViajar(p);

            Diretor d = new Diretor();
            IrViajar(d);

            Vendedor v = new Vendedor();
            IrViajar(v);
        }

        static void IrViajar(Pessoa p) {
            p.Viajar();
        }
    }
}
