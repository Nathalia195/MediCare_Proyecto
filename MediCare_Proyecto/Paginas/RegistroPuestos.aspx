<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroPuestos.aspx.cs" Inherits="MediCare_Proyecto.RegistroPuestos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>MediCare Solutions</title>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700" rel="stylesheet" />

     <link rel="stylesheet" href="css/style.css" />

     <link rel="stylesheet" href="../css/owl.carousel.min.css" />

    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
   

    
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <%--<link href="../ContentNathalia/css/bootstrap/sidebar.css" rel="stylesheet" />--%>

</head>
<body>
    <style type="text/css" media="screen">
        html, body {
            overflow: hidden;
        }
    </style>



    <form class="form-group" id="formAgregarInteres" runat="server" style="justify-content: center; align-items: center; margin-top: 150px">
        <div class="container" style="text-align: center">
            <b>
                <h4 style="color: #8C2641">Agregar un nuevo puesto</h4>
            </b>
        </div>
        <div class="container">
            <div class="form-group">
                <label for="txtCodigoPuesto">Código del Puesto:</label>
                <asp:TextBox ID="txtPuesto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtNombreInteres">Nombre del Puesto:</label>
                <asp:TextBox ID="txtNombrePuesto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group" style="justify-content: center; align-items: center; text-align: center">
                <asp:Button ID="btnAgregarPuesto" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarPuesto_Click" />
            </div>
        </div>
    </form>
   
    <script>
        function agregarPuesto() {
            // Obtener los valores de los campos del formulario

            var categoria = document.getElementById("ddlCategorias").value;
            var nombreInteres = document.getElementById("txtNombreInteres").value;

            // Realizar una petición al servidor para agregar el nuevo interés
            // ...

            // Cerrar la ventana emergente
            window.close();
        }
    </script>

</body>
</html>
