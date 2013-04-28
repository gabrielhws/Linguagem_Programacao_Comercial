using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio_4
{
    public partial class Default : System.Web.UI.Page
    {
        String url = String.Empty;
        String urlEmployee = "Employee.aspx";
        String urlManager = "Manager.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == String.Empty || txtUser.Text == String.Empty)
            {
                lblResult.Text = "Incorrect values user/password!";
                lblResult.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResult.Text = "The informations are correct.";
                lblResult.ForeColor = Color.Blue;
            }
            switch (txtUser.Text)
            {
                case "Eduardo":
                    if (txtPassword.Text == @"12\3456BD")
                        url = urlManager;
                    break;
                case "Antonio":
                    if (txtPassword.Text == "654789")
                        url = urlEmployee;
                    break;
                case "Gustavo":
                    if (txtPassword.Text == "987556" || txtPassword.Text == "154815")
                        url = urlEmployee;
                    break;
                case "Mateus":
                    if (txtPassword.Text == "545128")
                        url = urlEmployee;
                    break;
                case "Paulo":
                    if (txtPassword.Text == @"215@485AA")
                        url = urlManager;
                    break;
                default:
                    break;
            }
            Response.Redirect(url);
        }
    }
}