using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Sprint
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Backlog Backlog { get; set; }
        public int Posicao { get; set; }

        public Sprint() { }
    }
}
