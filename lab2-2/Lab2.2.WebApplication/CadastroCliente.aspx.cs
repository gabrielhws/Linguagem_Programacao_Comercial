using Lab2._2.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2._2.WebApplication
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string message = String.Empty;

            Cliente cliente = new Cliente(txtName.Text, int.Parse(txtAge.Text));
            cliente.Salvar(out message);

            lblMessage.Text = message;
        }
    }
}