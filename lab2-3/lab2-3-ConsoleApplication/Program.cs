using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3;

namespace lab2_3_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer c = new Costumer();
            c.Save();
            c.Travel();

            Seller s = new Seller();
            s.Save();
            s.Travel();

            Console.ReadKey();

        }
    }
}
