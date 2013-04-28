using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2_4_2
{
    public partial class wucLogin : System.Web.UI.UserControl
    {
        public delegate void delegateLogin(string usuario, string senha);
        public event delegateLogin EventoLogar;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            EventoLogar(txtUsuario.Text, txtSenha.Text);
        }

        public void AlterarMensagem(string mensagem) {
            lblMensagem.Text = mensagem;
        }
    }
}