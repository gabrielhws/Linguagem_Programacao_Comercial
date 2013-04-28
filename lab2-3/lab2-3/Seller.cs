using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3_Inteface;

namespace lab2_3
{
   public class Seller : Person, IProfissional
    {
        public string Formacao { get; set; }
        public string Titulo { get; set; }
        public decimal RendimentoMensal { get; set; }

        public Seller() {
            Formacao = "Superior completo";
            Titulo = "Vendedor";
            RendimentoMensal = 3000;
        }

        public override void Save() {
            Console.WriteLine("Method Save called in class Seller");
        }

        public void ModificarRendimentoMensal(decimal d)
        {
            this.RendimentoMensal += d;
        }

    }
}
