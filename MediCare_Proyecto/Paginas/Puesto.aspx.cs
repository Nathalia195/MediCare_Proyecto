using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediCare_Proyecto
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            string script = "window.open('RegistroPuestos.aspx', 'Agregar Puesto', 'width=500,height=500');";
            ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", script, true);
        }
    }
}