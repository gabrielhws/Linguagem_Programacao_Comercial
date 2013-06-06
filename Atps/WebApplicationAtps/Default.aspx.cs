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
            // Analisa se a sessão possui o parâmetro valor login, 
            // se sim converte para string e senão retornar uma string vazia
            String sessao =  (Session["login"] != null)? Session["login"].ToString():String.Empty;
            // Sessão estiver diferente de vazio e igual a verdadeira 
            // redireciona para a página de consulta
            if (sessao != String.Empty && sessao == "true")
            {
                Response.Redirect("Consulta.aspx");
            }
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
           
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;
            // Recebe o retorno do objeto login
            string retorno = login.validarAcesso();
            // se o retorno for igual a verdadeiro será setado na sessao
            // um valor de manipulação do login, senão retornar a mensagem em 
            // um label na tela de login
            if(retorno.Equals("true"))
                Session["login"] = "true";
            else 
                lblResultado.Text = retorno;
        }
    }
}