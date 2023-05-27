using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidad;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Datos
{
    public class DatosUsuario
    {
        public string cnx;


        EntidadUsuario mcEntidad = new EntidadUsuario();
        SqlCommand cmd = new SqlCommand();
        bool vexito;
        public DatosUsuario()
        {
            cnx = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        }


        public string Autentificacion(EntidadUsuario Usuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
                {
                    //ABRIMOS LA CONEXION
                    cnx.Open();

                    //DECLARAMOS LA CONSULTA
                    string sqlQuery = "sp_Autentificacionn";

                    //LE MANDAMOS LA CONSULTA A LA BASE DE DATOS
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                    {
                        //AGREGARON LOS PARAMETROS
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", Usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", Usuario.Contrasena);

                        SqlDataReader dr = cmd.ExecuteReader();
                        //DECLARAMOS LA CONSULTA
                        //string sqlQuery = "sp_Autentificacion";
                         

                        if (dr.Read())
                        {
                            return dr["Nombre"].ToString();
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public byte[] TraerAvatar(EntidadUsuario Usuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
                {
                    //ABRIMOS LA CONEXION
                    cnx.Open();

                    //DECLARAMOS LA CONSULTA
                    string sqlQuery = "sp_getAvatar";

                    //LE MANDAMOS LA CONSULTA A LA BASE DE DATOS
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                    {
                        //AGREGARON LOS PARAMETROS
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = Usuario.NombreUsuario;

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            byte[] imagen = (byte[])dr["Imagen"];
                            return imagen;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EntidadUsuario> GetUsuario()
        {
            List<EntidadUsuario> usuarios = new List<EntidadUsuario>();

            try
            {
                using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
                {
                    //ABRIMOS LA CONEXION
                    cnx.Open();

                    //DECLARAMOS LA CONSULTA
                    string sqlQuery = "sp_getUsuario";

                    //LE MANDAMOS LA CONSULTA A LA BASE DE DATOS
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            EntidadUsuario entidadUsuario = new EntidadUsuario
                            {
                                NombreUsuario = Convert.ToString(dr["NombreUsuario"]),
                                NombreCompleto = Convert.ToString(dr["NombreCompleto"]),
                                CorreoElectronico = Convert.ToString(dr["CorreoElectronico"]),
                                CodigoEstado = Convert.ToString(dr["NombreEstado"])
                            };
                            usuarios.Add(entidadUsuario);
                        }
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public bool InsertarUsuario(EntidadUsuario mcEntidad)
        {

            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "proc_insertar";
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
                {
                    //ABRIMOS LA CONEXION
                    cnx.Open();

                    //DECLARAMOS LA CONSULTA
                    string sqlQuery = "sp_insert_usuario";

                    //LE MANDAMOS LA CONSULTA A LA BASE DE DATOS
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                    {
                        

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", mcEntidad.NombreUsuario);
                        cmd.Parameters.AddWithValue("@NombreCompleto", mcEntidad.NombreCompleto);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", mcEntidad.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@Contrasena", mcEntidad.Contrasena);
                        cmd.Parameters.AddWithValue("@Imagen", mcEntidad.Imagen);
                        cmd.Parameters.AddWithValue("@CodigoRol", mcEntidad.CodigoRol);
                        cmd.Parameters.AddWithValue("@CodigoEstado", mcEntidad.CodigoEstado);

                        cmd.ExecuteNonQuery();
                        vexito = true;

                        cnx.Close();
                    }
                }
            }

            catch (SqlException ex)
            {
                vexito = false;
            }

            return vexito;
        }


        public bool EditarUsuario(EntidadUsuario mcEntidad)
        {

            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "proc_insertar";
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
                {
                    //ABRIMOS LA CONEXION
                    cnx.Open();

                    //DECLARAMOS LA CONSULTA
                    string sqlQuery = "sp_update_usuario";

                    //LE MANDAMOS LA CONSULTA A LA BASE DE DATOS
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCompleto", mcEntidad.NombreCompleto);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", mcEntidad.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@Contrasena", mcEntidad.Contrasena);
                        cmd.Parameters.AddWithValue("@Imagen", mcEntidad.Imagen);
                        cmd.Parameters.AddWithValue("@CodigoRol", mcEntidad.CodigoRol);
                        cmd.Parameters.AddWithValue("@CodigoEstado", mcEntidad.CodigoEstado);

                        cmd.ExecuteNonQuery();
                        vexito = true;

                        cnx.Close();
                    }
                }
            }

            catch (SqlException ex)
            {
                vexito = false;
            }

            return vexito;
        }






    }
}
