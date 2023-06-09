﻿
using System;
using System.Web;
using Negocio;

namespace MediCare_Proyecto
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        NegocioGeneral obj_general = new NegocioGeneral();

        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void Btn_oferente(object sender, EventArgs e)
        {
            //Response.Redirect("MantenimientoUsuario.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt("1," + Lbl_usuario.Text)));            
        }

        protected void Btn_puesto(object sender, EventArgs e)
        {
            Response.Redirect("Puesto.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt("1," + Lbl_usuario.Text)));            
        }

        protected void Btn_verificar(object sender, EventArgs e)
        {
            //Response.Redirect("MantenimientoUsuario.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt("1," + Lbl_usuario.Text)));            
        }

    }
}