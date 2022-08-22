<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarProduto.aspx.cs" Inherits="Empresa.Produto.CadastrarProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row text-center"><h2>Cadastrar Produto</h2></div>
        <br />
        <div class="row">
            <div class="col-sm-2">Descrição</div>
            <div class="col-sm-6">
                <asp:TextBox runat="server" ID="txtdescricao" CssClass="form-control" placeholder="Descrição: "></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-2">Estoque</div>
            <div class="col-sm-6">
                <asp:TextBox runat="server" ID="txtestoque" CssClass="form-control" placeholder="Estoque: "></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-2">Descrição</div>
            <div class="col-sm-6">
                <asp:TextBox runat="server" ID="txtvalor" CssClass="form-control" placeholder="Valor: "></asp:TextBox></div>
        </div>
        <br />
        <div class="row text-left">
            <asp:Button runat="server" ID="btnCadastrar" CssClass="btn btn-success" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </div>
        <br />
    </div>
</asp:Content>
