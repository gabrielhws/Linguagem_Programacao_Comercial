using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Backlog    :   Cadastro
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Relevancia { get; set; }
        public DateTime TempoPrevisto { get; set; }
        public DateTime TempoReal { get; set; }
        public int Posicao { get; set; }

        public Backlog() { }

        
    }
}
