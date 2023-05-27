<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MediCare_Proyecto.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="d-sm-flex flex-column align-items-center justify-content-center mb-4" style="text-align: center;">
        <img src="../img/logo(5).png" style="width: 300px; height: 300px" />

        <asp:Label class="h4 mb-0 text-gray-800" ID="Lbl_Bienvenida" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
