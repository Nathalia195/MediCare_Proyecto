using System;


namespace MediCare_Proyecto
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            string fullname = Session["fullname"].ToString();
          
            Lbl_Bienvenida.Text = "Bienvenido " + fullname;
         
        }
    }
}