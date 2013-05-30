using ATPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAtps
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ddlDepartamento_Load();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Material material = new Material();

            Departamento departamento = new Departamento();
            departamento.Codigo = Int32.Parse(ddlDepartamento.SelectedItem.Value);

            material.Departamento = departamento.GetDepartamento();

            material.Titulo = (txtTitulo.Text != String.Empty) ? txtTitulo.Text : String.Empty;

            DateTime de = (txtPeriodo.Text != String.Empty) ? DateTime.Parse(txtPeriodo.Text) : new DateTime();
            DateTime ate = (txtAte.Text != String.Empty) ? DateTime.Parse(txtAte.Text) : new DateTime();

            lvMateriais.DataSource = material.GetMateriais(de, ate);
            lvMateriais.DataBind();
        }


        protected void ddlDepartamento_Load()
        {
            ddlDepartamento.DataSource = new Departamento().GetDepartamentos();
            ddlDepartamento.DataTextField = "Descricao";
            ddlDepartamento.DataValueField = "Codigo";
            ddlDepartamento.DataBind();

            ddlDepartamento.Items.Insert(0, new ListItem("Selecione o Departamento", "0"));
            ddlDepartamento.SelectedIndex = 0;
        }


    }
}