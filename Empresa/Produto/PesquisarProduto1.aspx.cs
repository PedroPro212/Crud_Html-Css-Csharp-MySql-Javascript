using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empresa.Produto
{
    public partial class PesquisarProduto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            var produtos = new Negocio.Produto().Read("", txtPesquisa.Text, "", "");
            Session["dados"] = produtos;
            grdProdutos.DataSource = produtos;
            grdProdutos.DataBind();
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarProduto.aspx");
        }

        protected void grdProdutos_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProdutos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grdProdutos_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            var produtos = (List<Classes.Produto>)Session["dados"];
            grdProdutos.PageIndex = e.NewPageIndex;
            grdProdutos.DataSource = produtos;
            grdProdutos.DataBind();
        }

        protected void grdProdutos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var produtos = (List<Classes.Produto>)Session["dados"];

            if(e.CommandName == "excluir")
            {
                if (new Negocio.Produto().Delete(produtos[index].Id))
                    SiteMaster.ExibirAlert(this, "Excluido com sucesso!");
                else
                    SiteMaster.ExibirAlert(this, "O produto não pode ser excluído porque ele está sendo usado! ");
                btnPesquisa_Click(null, null);
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarProduto.aspx?Id=" + produtos[index].Id);
            }
        }
    }
}