using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediCare_Proyecto
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {


        NegocioGeneral obj_general = new NegocioGeneral();
        NegocioUsuario obj_usuario = new NegocioUsuario();
        NegocioEstado obj_estado = new NegocioEstado();
        NegocioRol obj_rol = new NegocioRol();
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            string fullname = Session["fullname"].ToString();
            string rol = Session["rol"].ToString();
            if (!IsPostBack)
            {
                //string myVar = obj_general.Decrypt(HttpUtility.UrlDecode(Request.QueryString["MyVar"]));

                if (!string.IsNullOrEmpty(rol))
                {
                    //url = myVar;
                    //myVar.Split(',')[0]; NombreUsuario
                    //myVar.Split(',')[1]; NombreCompleto
                    //myVar.Split(',')[2]; Rol
                    if (rol != "AD")
                    {
                        MostrarMensaje("Lo sentimos, usted no tiene acceso a este mantenimiento");
                    }
                    else
                    {
                        List<EntidadUsuario> usuario = obj_usuario.GetUsuario();

                        Dgv_usuario.DataSource = usuario;
                        Dgv_usuario.DataBind();

                        //List<EntidadEstado> estado = obj_estado.GetEstado();

                        //int i = 0;

                        //foreach (EntidadEstado c in estado)
                        //{
                        //    ddl_estado.Items.Insert(i, new ListItem(c.NombreEstado, c.CodigoEstado));
                        //    i += 1;
                        //}

                        //List<EntidadRol> rol = obj_rol.GetRol();

                        //i = 0;

                        //foreach (EntidadRol c in rol)
                        //{
                        //    ddl_rol.Items.Insert(i, new ListItem(c.NombreRol, c.CodigoRol));
                        //    i += 1;
                        //}
                    }
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
        }


        private void MostrarMensaje(string mensaje)
        {
            string message = mensaje;
            string url1 = "MantenimientoUsuario.aspx?MyVar=" + HttpUtility.UrlEncode(obj_general.Encrypt(url));
            string script = "{ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url1;
            script += "'; }";
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "alert", script, true);
        }


        protected void Dgv_usuario_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                string columna = Dgv_usuario.Rows[fila].Cells[0].Text;
                Session["llave"] = columna;

                Response.Redirect("AgregarUsuario.aspx");
            }
            else
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                string columna = Dgv_usuario.Rows[fila].Cells[0].Text;

                //LLAMAR FUNCION PARA ELIMINAR y pasar columna                

                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('Hello World');", true);
            }
        }




        protected void redi(object sender, EventArgs e)
        {
            Response.Redirect("AgregarUsuario.aspx");
        }

        
    }
}