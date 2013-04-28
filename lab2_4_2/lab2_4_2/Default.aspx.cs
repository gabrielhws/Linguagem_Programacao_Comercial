using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2_4_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wucLogin1.EventoLogar += new wucLogin.delegateLogin(wucLogin1_EventoLogar);
        }

        void wucLogin1_EventoLogar(string usuario, string senha) {
            string loginCerto = "usuario";
            string senhaCerta = "senha";

            if (loginCerto.Equals(usuario) && senhaCerta.Equals(senha))
                wucLogin1.AlterarMensagem("Login Correto");
            else
                wucLogin1.AlterarMensagem("Login Incorreto");
        }
     }
}