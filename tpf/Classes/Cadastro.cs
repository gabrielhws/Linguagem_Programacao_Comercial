using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cadastro
    {
        public  String cadastrar()
        {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.cadastrar(this);
        }

        public virtual String alterar()
        {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.alterar(this);
        }

        public virtual String deletar()
        {
            ConnectionFactory factory = new ConnectionFactory();
            return factory.deletar(this);
        }

    }
}
