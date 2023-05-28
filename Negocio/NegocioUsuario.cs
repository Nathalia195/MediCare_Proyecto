using Datos;
using Entidad;
using System.Collections.Generic;


namespace Negocio
{
    public class NegocioUsuario
    {
        DatosUsuario obj_datos = new DatosUsuario();

        public string Autentificacion(EntidadUsuario Usuario)
        {
            if (!string.IsNullOrEmpty(ValidarUsuario(Usuario)))
            {
                return obj_datos.Autentificacion(Usuario);
            }
            else
            {
                return "";
            }
        }

        private string ValidarUsuario(EntidadUsuario Usuario)
        {
            if (string.IsNullOrEmpty(Usuario.NombreUsuario) || string.IsNullOrEmpty(Usuario.Contrasena)) return ""; else return "ok";
        }
<<<<<<< HEAD
        private string ValidarUsuario1(EntidadUsuario Usuario)
        {
            if (string.IsNullOrEmpty(Usuario.NombreUsuario)  ||
                string.IsNullOrEmpty(Usuario.NombreCompleto) ||
                string.IsNullOrEmpty(Usuario.CorreoElectronico) ||  
                string.IsNullOrEmpty(Usuario.Contrasena)   ||
                string.IsNullOrEmpty(Usuario.Imagen.ToString()))
                return "Debe de completar todos los campos"; 
                else return "";
        }
=======

        private string ValidarUsuario1(EntidadUsuario Usuario)
        {
            if (string.IsNullOrEmpty(Usuario.NombreUsuario) || string.IsNullOrEmpty(Usuario.NombreCompleto) || string.IsNullOrEmpty(Usuario.CorreoElectronico) || string.IsNullOrEmpty(Usuario.Contrasena) ||  string.IsNullOrEmpty(Usuario.Imagen.ToString()))return "Debe de completar todos los campos"; else return "";
        }

        public byte[] TraerAvatar(EntidadUsuario Usuario)
        {
            return obj_datos.TraerAvatar(Usuario);
        }


>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
        public List<EntidadUsuario> GetUsuario()
        {
            return obj_datos.GetUsuario();
        }
        public void BloquearUsuario(EntidadUsuario usuario)
        {
            obj_datos.BloquearUsuario(usuario);
        }

<<<<<<< HEAD
        public void BloquearUsuario(EntidadUsuario usuario)
        {
            obj_datos.BloquearUsuario(usuario);
        }


        public string InsertarUsuarios(EntidadUsuario mcEntidad)
        {
=======

        public string InsertarUsuarios(EntidadUsuario mcEntidad)
        {
>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
            string mensaje = ValidarUsuario1(mcEntidad);

            if (string.IsNullOrEmpty(mensaje))
            {
<<<<<<< HEAD
                return obj_datos.InsertarUsuarios(mcEntidad);
=======
                return   obj_datos.InsertarUsuarios(mcEntidad);
>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
            }
            else
            {
                return mensaje;
            }
<<<<<<< HEAD



=======
           

              
>>>>>>> 99b6111 (Crud, bloqueo, avatar de usuarios)
        }



        //public void Editar(EntidadUsuario mcEntidad)
        //{
        //    obj_datos.EditarUsuario(mcEntidad);
        //}

    }
}
