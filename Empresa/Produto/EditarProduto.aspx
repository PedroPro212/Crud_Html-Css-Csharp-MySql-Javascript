<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProduto.aspx.cs" Inherits="Empresa.Produto.EditarProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row text-center">
        <h2>Editar Produto</h2>
    </div>
    <br />
    <div class="row">
        <div class="col-sm-2">Descrição:</div>
        <div class="col-sm-4">
            <asp:TextBox runat="server" ID="txtDescricao" CssClass="form-control"></asp:TextBox></div>
    </div>
    <div class="row">
        <div class="col-sm-2">Estoque:</div>
        <div class="col-sm-4">
            <asp:TextBox runat="server" ID="txtEstoque" CssClass="form-control"></asp:TextBox></div>
    </div>
    <div class="row">
        <div class="col-sm-2">Valor:</div>
        <div class="col-sm-4">
            <asp:TextBox runat="server" ID="txtValor" CssClass="form-control"></asp:TextBox></div>
    </div>
    <div class="row text-center">
        <asp:Button runat="server" ID="btnEditar" CssClass="btn btn-success" Text="Editar" OnClick="btnEditar_Click" />
    </div>
</asp:Content>
