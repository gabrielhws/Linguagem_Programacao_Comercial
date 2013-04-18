using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pessoa
    {
        public virtual void Viajar() { 
            Console.WriteLine("Viajar em Pessoa");
        }
    }
}
