﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ATPS
{
    public class Login
    {
        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private Boolean tipo;

        public Boolean Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Login()
        {
        }

        public string validarAcesso()
        {
            ConnectionFactory c = new ConnectionFactory();
            return c.validar(this);
        }


    }
}