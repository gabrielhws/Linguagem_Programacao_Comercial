using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FileXML
{
    public class XMLParsers
    {
        private string url = "http://localhost:2514/musicas.xml";

        public List<Musica> readerXML()
        {
            List<Musica> musicas = new List<Musica>();
            XDocument doc = XDocument.Load(url);
                        
            // LINQ, faz um pesquisa dentro do XML
            musicas = (from item in
                           doc.Descendants("item")
                       select new Musica()
                       {
                           // seta o title da Musica encontrado no XML
                           title = item.Element("title").Value,
                           link = new Uri(item.Element("link").Value),
                           description = item.Element("description").Value,
                           pubDate = DateTime.Parse(item.Element("pubDate").Value)

                       }).ToList<Musica>();

            return musicas;
        }       
    }
}
