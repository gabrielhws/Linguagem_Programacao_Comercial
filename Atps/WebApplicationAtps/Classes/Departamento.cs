using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATPS
{
    public class Departamento
    {
        private long codigo;

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Departamento()
        {
        }

        public Departamento(long codigo)
        {
            this.Codigo = codigo;
        }

        public Departamento GetDepartamento() {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.GetDepartamento(this.Codigo);
        }

        public List<Departamento> GetDepartamentos()
        {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.GetDepartamentos();
        }
    }
}