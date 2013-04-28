using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3_Inteface
{
    public interface IProfissionalInsdustria : IProfissional
    {
        DateTime HoraEntrada { get; }
        DateTime HoraSaida { get;}
        string Turno { get;}

        void AlterarTurno(string novoTurno);
    }
}
