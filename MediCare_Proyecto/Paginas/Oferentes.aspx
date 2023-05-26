<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Oferentes.aspx.cs" Inherits="MediCare_Proyecto.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body id="page-top">

    
           
                <div class="container-fluid">

                    <!-- Page Heading -->


                    <form id="form1" runat="server">
                        <h2>Oferentes</h2>
                        <div>
                            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="false" Width="90%" CssClass="gridview">
                                <Columns>
                                    <asp:BoundField DataField="CodigoPuesto" HeaderText="Codigo Puesto" />
                                    <asp:BoundField DataField="NombrePuesto" HeaderText="Nombre Puesto" />

                                </Columns>
                            </asp:GridView>

                        </div>
                    </form>



                </div>
                <!-- /.container-fluid -->

     
            <!-- End of Main Content -->

            <!-- Footer -->
            <footer class="sticky-footer bg-white">
                <div class="container my-auto">
                    <div class="copyright text-center my-auto">
                        <span>Copyright &copy; MediCare Solutions 2023</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->
     
        <!-- End of Content Wrapper -->


    <!-- End of Page Wrapper -->

    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
        <i class="fas fa-angle-up"></i>
    </a>
</body>
</asp:Content>
