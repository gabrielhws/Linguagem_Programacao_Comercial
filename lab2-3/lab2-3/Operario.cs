using lab2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3_Inteface
{
    public class Operario : Person, IProfissional, IProfissionalInsdustria
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public string Formacao { get; set; }
        public string Titulo { get; set; }
        public string Turno { get; set; }
        public decimal RendimentoMensal { get; set; }

        public Operario() {
            HoraEntrada = DateTime.Now;
            Formacao = "tecnica";
            Titulo = "operário";
            Turno = "turno1";
        }

        public void ModificarRendimentoMensal(decimal variacao)
        {
            if (variacao > 0)
            {
                RendimentoMensal += (decimal)0.85 * variacao;
                Console.WriteLine("15% do seu aumento foi abocanhado");
                Console.WriteLine("Salário ANTERIOR : " + (RendimentoMensal - (decimal)0.85 * variacao).ToString("c"));
                Console.WriteLine("Salário ATUAL : " + RendimentoMensal.ToString("c"));
                Console.WriteLine("Variação BRUTA : " + variacao.ToString("c"));
                Console.WriteLine("Variação LÍQUIDA : " + ((decimal)0.85 * variacao).ToString("c"));
            }
        }

        public void AlterarTurno(string novoTurno) { }

        public override void Save()
        {
            Console.WriteLine("Method Save Called in class Operario");
        }
    }
}
