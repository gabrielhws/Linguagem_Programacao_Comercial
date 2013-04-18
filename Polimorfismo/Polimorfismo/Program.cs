using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        public static void Main(string[] args) {
            Pessoa p = new Pessoa();
            IrViajar(p);
        }

        static void IrViajar(Pessoa p) {
            p.Viajar();
        }
    }
}
