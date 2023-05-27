
using System;
using System.Web;
using Negocio;

namespace MediCare_Proyecto
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        NegocioGeneral obj_general = new NegocioGeneral();
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            //string myVar = obj_general.Decrypt(HttpUtility.UrlDecode(Request.QueryString["MyVar"]));
            //myVar.Split(',')[0]; NombreUsuario
            //myVar.Split(',')[1]; NombreCompleto
            //myVar.Split(',')[2]; Rol
            //myVar.Split(',')[3]; Validación que viene de login

            string username = Session["username"].ToString();
            string fullname = Session["fullname"].ToString();
            string rol = Session["rol"].ToString();

             Lbl_usuario.Text = username;
             

            imgURL.ImageUrl = "Paginas/MostrarImagen.aspx?id=" + Lbl_usuario.Text;
        }


        protected void Btn_usuario(object sender, EventArgs e)
        {
            Response.Redirect("MantUsuario.aspx");
        }
        protected void Btn_Index(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Btn_puesto(object sender, EventArgs e)
        {
            Response.Redirect("Puesto.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt("1," + Lbl_usuario.Text)));            
        }

        protected void Btn_oferente(object sender, EventArgs e)
        {
            Response.Redirect("Oferentes.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt(url)));
        }

     

        protected void Btn_verificar(object sender, EventArgs e)
        {
            //Response.Redirect("MantenimientoUsuario.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt("1," + Lbl_usuario.Text)));            
        }

  
    }
}