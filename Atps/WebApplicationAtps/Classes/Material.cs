using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATPS
{
    public class Material
    {
        private long codigo;

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private Departamento departamento;

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private String conteudo;

        public String Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }
        private long codigo_usuario;

        public long Codigo_usuario
        {
            get { return codigo_usuario; }
            set { codigo_usuario = value; }
        }

        public Material()
        {
        }

        public List<Material> GetMateriais(DateTime de, DateTime ate)
        {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.GetMateriais(this, de, ate);
        }


    }
}