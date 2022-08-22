<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PesquisarProduto1.aspx.cs" Inherits="Empresa.Produto.PesquisarProduto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Pesquisar Produtos</h1>
    </div>
    <br />
    <br />
    <div class="rows">
        <div class="col-sm-3">
            <asp:TextBox runat="server" ID="txtPesquisa" CssClass="form-control" placeholder="Digite o produto aqui para buscar"></asp:TextBox>
        </div>
        <div class="col-sm-5">
        </div>
        <br />
        <div class="row text-center">
            <asp:Button runat="server" ID="btnPesquisa" CssClass="btn btn-primary" OnClick="btnPesquisa_Click" Text="Pesquisar" />
            <asp:Button runat="server" ID="btnCadastro" CssClass="btn btn-success" OnClick="btnCadastro_Click" Text="Cadastrar" />
        </div>
    </div>
    <br />
    <div class="row">
        <asp:GridView runat="server" ID="grdProdutos" Width="100%" AutoGenerateColumns="false"
            CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
            OnRowCommand="grdProdutos_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdProdutos_PageIndexChanging1">
            <Columns>
                <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO" />
                <asp:BoundField DataField="estoque" HeaderText="ESTOQUE" />
                <asp:BoundField DataField="valor" HeaderText="VALOR" />
                <asp:ButtonField ButtonType="Link" CommandName="editar" ControlStyle-CssClass="btn btn-warning" Text="Editar" />
                <asp:ButtonField ButtonType="Link" CommandName="excluir" ControlStyle-CssClass="btn btn-danger" Text="Excluir" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>