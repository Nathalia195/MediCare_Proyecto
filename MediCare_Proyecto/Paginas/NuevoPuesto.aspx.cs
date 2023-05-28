using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediCare_Proyecto
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        NegocioGeneral obj_general = new NegocioGeneral();
        Negocio_Puesto obj_Puesto = new Negocio_Puesto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void agregarPuesto_Click(object sender, EventArgs e)
        {
            //string script = "window.open('NuevoPuesto.aspx', 'Agregar Puesto', 'width=500,height=500');";
            //ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", script, true);
        }
    }
}