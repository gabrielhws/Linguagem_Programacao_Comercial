using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_2_4_1
{
    public partial class Secundaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Session["origem"] = txtOrigem.Text;
        }

        protected void btnCopiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = (String)Session["origem"];
        }
    }
}