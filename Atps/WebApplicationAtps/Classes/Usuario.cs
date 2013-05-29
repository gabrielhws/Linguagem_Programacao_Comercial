using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATPS
{
    public class Usuario
    {
        private long codigo;

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private Login login;

        internal Login Login
        {
            get { return login; }
            set { login = value; }
        }

        public Usuario()
        {

        }

        public void cadastrarUsuario()
        {
        }

        public void consultarUsuario()
        {
        }
    }
}