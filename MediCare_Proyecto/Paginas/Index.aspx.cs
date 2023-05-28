using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediCare_Proyecto
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {

        NegocioGeneral obj_general = new NegocioGeneral();
        protected void Page_Load(object sender, EventArgs e)
        {

            //string username = Session["username"].ToString();
           // string fullname = Session["fullname"].ToString();
           // string rol = Session["rol"].ToString();
            //Lbl_Bienvenida.Text = "Bienvenido " + fullname;
            //string myVar = obj_general.Decrypt(HttpUtility.UrlDecode(Request.QueryString["MyVar"]));
            //if (!string.IsNullOrEmpty(myVar))
            //{
            //    //myVar.Split(',')[0]; NombreUsuario
            //    //myVar.Split(',')[1]; NombreCompleto
            //    //myVar.Split(',')[2]; Rol
            //    Lbl_Bienvenida.Text = "Bienvenido " + myVar.Split(',')[1];
            //}
            //else
            //{
            //    Response.Redirect("Login.aspx");
            //}
        }
    }
}