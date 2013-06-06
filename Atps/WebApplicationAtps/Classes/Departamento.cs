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
            // Instância um novo objeto da Classe ConnectionFactory
            // e retorna um objeto da Classe departamento de acordo
            // com o código passado no parâmetro
            ConnectionFactory factory = new ConnectionFactory();
            return factory.GetDepartamento(this.Codigo);
        }

        public List<Departamento> GetDepartamentos()
        {
            // Instância um novo objeto da Classe ConnectionFactory
            // e retorna a lista de departamentos do banco de dados
            ConnectionFactory factory = new ConnectionFactory();
            return factory.GetDepartamentos();
        }
    }
}