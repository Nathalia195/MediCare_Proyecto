using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediCare_Proyecto
{
    public partial class login : System.Web.UI.Page
    {
        NegocioUsuario obj_negocio = new NegocioUsuario();
        private EntidadUsuario Usuario;

        protected void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuario == null) Usuario = new EntidadUsuario();


                Usuario.NombreUsuario = Txt_usuario.Text;
                Usuario.Contrasena = Txt_contrasena.Text;

                string Mensaje = obj_negocio.Autentificacion(Usuario);

                if (String.IsNullOrEmpty(Mensaje))
                {
                    MostrarMensaje("Usuario y/o contraseña incorrectos.");
                }
                else
                {
                    Session["username"] = Mensaje.Split(',')[0];
                    Session["fullname"] = Mensaje.Split(',')[1];
                    Session["rol"] = Mensaje.Split(',')[2];
                    Response.Redirect("Index.aspx");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message);
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            string message = mensaje;
            string url = "Login.aspx";
            string script = "{ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "alert", script, true);
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}