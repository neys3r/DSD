using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class AsesorDAO
    {
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=VWallet;Integrated Security=True;";

        public string Americo(string nombre)
        {
            return nombre;
        }

        public Asesor Crear(Asesor asesorACrear)
        {
            Asesor asesorCreado = null;
            string sql = "INSERT INTO t_asesor VALUES (@dni, @nombre, @estado)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", asesorACrear.Dni));
                    comando.Parameters.Add(new SqlParameter("@nombre", asesorACrear.Nombre));
                    comando.Parameters.Add(new SqlParameter("@estado", asesorACrear.Estado));
                    comando.ExecuteNonQuery();
                }
            }
            asesorCreado = Obtener(asesorACrear.Dni);
            return asesorCreado;
        }
        public Asesor Obtener(int dni)
        {
            Asesor asesorEncontrado = null;
            string sql = "SELECT * FROM t_asesor WHERE nu_dni=@dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            asesorEncontrado = new Asesor()
                            {
                                Dni = (int)resultado["nu_dni"],
                                Nombre = (string)resultado["tx_nombre"],
                                Estado = (string)resultado["tx_estado"]
                            };
                        }
                    }
                }
            }
            return asesorEncontrado;
        }
        public Asesor Modificar(Asesor asesorAModificar)
        {
            Asesor asesorModificado = null;
            string sql = "UPDATE t_asesor SET tx_nombre=@nombre, tx_estado=@estado WHERE nu_dni=@dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombre", asesorAModificar.Nombre));
                    comando.Parameters.Add(new SqlParameter("@estado", asesorAModificar.Estado));
                    comando.Parameters.Add(new SqlParameter("@dni", asesorAModificar.Dni));
                    comando.ExecuteNonQuery();
                }
            }
            asesorModificado = Obtener(asesorAModificar.Dni);
            return asesorModificado;
        }
        public void Eliminar(int dni)
        {
            string sql = "DELETE FROM  t_asesor WHERE nu_dni=@dni";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Asesor> Listar()
        {
            List<Asesor> asesoresEncontrados = new List<Asesor>();
            Asesor asesoresEncontrado = null;

            string sql = "SELECT * FROM t_asesor";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            asesoresEncontrado = new Asesor()
                            {
                                Dni = (int)resultado["nu_dni"],
                                Nombre = (string)resultado["tx_nombre"],
                                Estado = (string)resultado["tx_estado"]
                            };
                            asesoresEncontrados.Add(asesoresEncontrado);
                        }
                    }
                }

            }

            return asesoresEncontrados;
        }
    }
}