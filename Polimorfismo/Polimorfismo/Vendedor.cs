using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Vendedor : Pessoa
    {
        public void Viajar()
        {
            Console.WriteLine("Viajar em Vendedor");
        }
    }
}
