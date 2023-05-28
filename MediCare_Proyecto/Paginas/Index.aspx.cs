using System;


namespace MediCare_Proyecto
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
            string fullname = Session["fullname"].ToString();
          
            Lbl_Bienvenida.Text = "Bienvenido " + fullname;
         
<<<<<<< HEAD
>>>>>>> 364a3a76cd3f91e55549bb4bacec7ae258512bf0
=======
>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
        }
    }
}