using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
   public class Costumer : Person
    {
        public Costumer() { }

        public override void Save() {
            Console.WriteLine("Method Save called in class Costumer");
        }
    }
}
