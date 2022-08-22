using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empresa.Produto
{
    public partial class CadastrarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txtvalor.Text = 0.ToString("C");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var produto = new Classes.Produto();
            var x = txtvalor.Text.Split(' ');
            produto.Descricao = txtdescricao.Text;
            produto.Estoque = Convert.ToInt32(txtestoque.Text);
            produto.Valor = Convert.ToDouble(x[1]);
            new Negocio.Produto().Create(produto);

            SiteMaster.ExibirAlert(this, "Cadastrado com sucesso!", "PesquisarProduto1.aspx");
            txtdescricao.Text = "";
            txtestoque.Text = "";
            txtvalor.Text = 0.ToString("C");
        }
    }
}