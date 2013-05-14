using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileXML
{
    public class Musica
    {
        public string title { get; set; }
        public Uri link { get; set; }
        public string description { get; set; }
        public DateTime pubDate { get; set; }

        public Musica() { }

    }
}
