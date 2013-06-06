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
            // Verifica se o carregamento da page é diferente de IsPostBack, 
            // se sim carrega o ComboBox do departamento
            if (!IsPostBack)
                ddlDepartamento_Load();

            // Analisa se a sessão possui o parâmetro valor login, 
            // se sim converte para string e senão retornar uma string vazia
            String sessao = (Session["login"] != null) ? Session["login"].ToString() : String.Empty;
            // Sessão estiver vazio ou diferente de verdadeira 
            // redireciona para a página de login
            if (sessao == String.Empty || sessao != "true")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Material material = new Material();

            Departamento departamento = new Departamento();
            // Converte o codigo do departamento selecionado no ComboBox
            // para Inteiro
            departamento.Codigo = Int32.Parse(ddlDepartamento.SelectedItem.Value);
            // Set o departamento ao atributo departamento do objeto material
            material.Departamento = departamento.GetDepartamento();

            material.Titulo = (txtTitulo.Text != String.Empty) ? txtTitulo.Text : String.Empty;

            // Converte as datas em String para o tipo DateTime
            DateTime de = (txtPeriodo.Text != String.Empty) ? DateTime.Parse(txtPeriodo.Text) : new DateTime();
            DateTime ate = (txtAte.Text != String.Empty) ? DateTime.Parse(txtAte.Text) : new DateTime();

            // Set os materias retornados na lista que será exibida na página de consulta
            lvMateriais.DataSource = material.GetMateriais(de, ate);
            lvMateriais.DataBind();
        }


        protected void ddlDepartamento_Load()
        {
            // Set os departamentos que serão exibidos no ComboBox
            ddlDepartamento.DataSource = new Departamento().GetDepartamentos();
            // Campo de visualização do ComboBox
            ddlDepartamento.DataTextField = "Descricao";
            // Campo de valor do ComboBox
            ddlDepartamento.DataValueField = "Codigo";
            ddlDepartamento.DataBind();

            // Insere um item de auxilio e coloca-o como selecionado
            ddlDepartamento.Items.Insert(0, new ListItem("Selecione o Departamento", "0"));
            ddlDepartamento.SelectedIndex = 0;
        }


    }
}