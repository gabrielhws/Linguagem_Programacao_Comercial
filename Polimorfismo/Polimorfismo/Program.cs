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
            string op = null;
            do
            {
                Pessoa p = null;
                op = Menu();
                switch (op)
                {
                    case "D":
                        p = new Diretor();
                        CalcularSalario(p);
                        break;
                    case "V":
                        p = new Vendedor();
                        CalcularSalario(p);
                        break;
                    case "F":
                        p = new Funcionario();
                        CalcularSalario(p);
                        break;
                    case "E":
                        p = new Estagiario();
                        CalcularSalario(p);
                        break;
                }

            } while (op != "S");

            Console.ReadKey();
        }

        static void CalcularSalario(Pessoa p) {
            p.Salario();
        }

        static string Menu() {

            Console.WriteLine("Entre com o tipo de Pessoa: ");
            Console.WriteLine("D - Diretor");
            Console.WriteLine("V - Vendedor");
            Console.WriteLine("F - Funcionário");
            Console.WriteLine("E - Estagiário");
            Console.WriteLine("S - Sair");
            Console.WriteLine("Opçao: ");
            
            return Console.ReadLine();
       }
    }
}
