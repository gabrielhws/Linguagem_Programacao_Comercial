using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3_Inteface
{
    public interface IProfissional
    {
        string Formacao { get;}
        string Titulo { get; }
        decimal RendimentoMensal { get; }

        void ModificarRendimentoMensal(decimal variacao);
    }
}
