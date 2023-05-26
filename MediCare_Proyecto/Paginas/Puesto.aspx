<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Puesto.aspx.cs" Inherits="MediCare_Proyecto.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Begin Page Content -->
    <div class="container-fluid">

        <!-- Page Heading -->
        <div style="max-width: 800px; margin: 0 auto;">

            <h2 style="text-align: center;">Puestos</h2>
            <div style="text-align: center; margin-top: 50px; margin-bottom: 10px;">
                <asp:LinkButton ID="btnAgregarPuesto" runat="server" CssClass="btn btn-primary" OnClick="btnAgregarPuesto_Click">
    <i class="fas fa-plus"></i> Crear Puesto
                </asp:LinkButton>




                <asp:LinkButton ID="btnModificar" runat="server" CssClass="btn btn-warning">
    <i class="fas fa-pencil-alt"></i> Modificar
                </asp:LinkButton>

            </div>
            <div style="overflow-x: auto;">
                <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="false" CssClass="gridview" Style="width: 100%;">
                    <Columns>
                        <asp:BoundField DataField="CodigoPuesto" HeaderText="Codigo Puesto" />
                        <asp:BoundField DataField="NombrePuesto" HeaderText="Nombre Puesto" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>




    </div>


</asp:Content>
