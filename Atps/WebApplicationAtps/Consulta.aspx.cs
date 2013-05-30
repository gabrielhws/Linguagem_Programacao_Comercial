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
            setDropDown();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public IQueryable<Material> GetData() {
            Material material = new Material();
            return material.consultarMaterial().AsQueryable();
        }

        private void setDropDown() {
            ddlDepartamento.DataSource = new Departamento().getDepartamentos();
            ddlDepartamento.DataTextField = "Descricao";
            ddlDepartamento.DataValueField = "Codigo";
            ddlDepartamento.DataBind();

            ddlDepartamento.Items.Insert(0, "Selecione o Departamento");
            ddlDepartamento.SelectedIndex = 0;
        }
    }
}