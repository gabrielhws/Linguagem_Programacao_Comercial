using ATPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplicationAtps
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
           
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            string retorno = login.validarAcesso();
            if (retorno.Equals("true"))
                Response.Redirect("Consulta.aspx");
            else
                lblResultado.Text = retorno;
        }
    }
}