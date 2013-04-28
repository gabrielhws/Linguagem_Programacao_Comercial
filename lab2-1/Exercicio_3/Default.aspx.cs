using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == String.Empty || txtPassword.Text == String.Empty)
            {
                lblResult.Text = "Incorrect values user/password!";
                lblResult.ForeColor = Color.Red;
            }
            else
            {
                lblResult.Text = "The informations are correct.";
                lblResult.ForeColor = Color.Blue;
            }
        }
    }
}