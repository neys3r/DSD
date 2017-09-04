using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class UsuarioDAO
    {
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=VWallet;Integrated Security=True;";

        public Usuario Crear(Usuario usuarioACrear)
        {
            Usuario usuarioCreado = null;
            string sql = "INSERT INTO MAE_USUARIO VALUES (@CodigoUsuario ,@DescUsuario,@TipoUsuario,@Contrasena,@CodigoCliente,@Estado)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@CodigoUsuario", usuarioACrear.CodigoUsuario));
                    comando.Parameters.Add(new SqlParameter("@DescUsuario", usuarioACrear.DescUsuario));
                    comando.Parameters.Add(new SqlParameter("@TipoUsuario", usuarioACrear.TipoUsuario));
                    comando.Parameters.Add(new SqlParameter("@Contrasena", usuarioACrear.Contrasena));
                    comando.Parameters.Add(new SqlParameter("@CodigoCliente", usuarioACrear.CodigoCliente));
                    comando.Parameters.Add(new SqlParameter("@Estado", usuarioACrear.Estado));
                    comando.ExecuteNonQuery();
                }
            }
            usuarioCreado = Obtener(usuarioACrear.CodigoUsuario);
            return usuarioCreado;
        }

        public Usuario Obtener(string CodigoUsuario)
        {

            Usuario usuarioEncontrado = null;
            string sql = "SELECT * FROM MAE_USUARIO WHERE COD_USR=@CodigoUsuario";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@CodigoUsuario", CodigoUsuario));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())

                        {

                            usuarioEncontrado = new Usuario()
                            {

                                CodigoUsuario = (string)resultado["COD_USR"],
                                DescUsuario = (string)resultado["DES_USR"],
                                TipoUsuario = (string)resultado["TIP_USR"],
                                Contrasena = (string)resultado["DES_PSSW"],
                                CodigoCliente = (string)resultado["COD_CLI"],
                                Estado = (bool)resultado["COD_EST"]
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }


        public Usuario Modificar(Usuario usuarioAModificar)
        {
            Usuario usuarioModificado = null;
            string sql = "UPDATE MAE_USUARIO SET DES_USR=@DescUsuario,TIP_USR=@TipoUsuario,DES_PSSW=@Contrasena,COD_CLI=@CodigoCliente,COD_EST=@Estado,COD_USR=@CodigoUsuario";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@DescUsuario", usuarioAModificar.DescUsuario));
                    comando.Parameters.Add(new SqlParameter("@TipoUsuario", usuarioAModificar.TipoUsuario));
                    comando.Parameters.Add(new SqlParameter("@Contrasena", usuarioAModificar.Contrasena));
                    comando.Parameters.Add(new SqlParameter("@CodigoCliente", usuarioAModificar.CodigoCliente));
                    comando.Parameters.Add(new SqlParameter("@Estado", usuarioAModificar.Estado));
                    comando.Parameters.Add(new SqlParameter("@CodigoUsuario", usuarioAModificar.CodigoUsuario));
                    comando.ExecuteNonQuery();
                }
            }
            usuarioModificado = Obtener(usuarioAModificar.CodigoUsuario);
            return usuarioModificado;
        }


        public List<Usuario> Listar()
        {
            List<Usuario> usuariosEncontrados = new List<Usuario>();
            Usuario usuariosEncontrado = null;

            string sql = "SELECT * FROM MAE_USUARIO";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            usuariosEncontrado = new Usuario()
                            {
                                CodigoUsuario = (string)resultado["COD_USR"],
                                DescUsuario = (string)resultado["DES_USR"],
                                TipoUsuario = (string)resultado["TIP_USR"],
                                Contrasena = (string)resultado["DES_PSSW"],
                                CodigoCliente = (string)resultado["COD_CLI"],
                                Estado = (bool)resultado["COD_EST"]
                            };
                            usuariosEncontrados.Add(usuariosEncontrado);
                        }
                    }
                }

            }

            return usuariosEncontrados;
        }


    }
}