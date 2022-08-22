using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empresa.Produto
{
    public partial class EditarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["id"].ToString();
                var produto = new Negocio.Produto().Read(id);
                if(produto == null)
                {
                    SiteMaster.ExibirAlert(this, "Produto não localizado, realize a pesquisa novamente", "PesquisarProduto.aspx");
                    return;
                }
                txtDescricao.Text = produto.Descricao;
                txtEstoque.Text = produto.Estoque.ToString();
                txtValor.Text = produto.Valor.ToString();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            var produto = new Classes.Produto();
            produto.Id = Convert.ToInt32(Request.QueryString["id"].ToString());
            produto.Descricao = txtDescricao.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Estoque = Convert.ToInt32(txtEstoque.Text);

            new Negocio.Produto().UPDATE(produto);
            SiteMaster.ExibirAlert(this, "Produto atualizado com sucesso!", "PesquisarProduto1.aspx");
        }
    }
}