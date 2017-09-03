using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class ClienteDAO
    {
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=VWallet;Integrated Security=True;";

        public Cliente Crear(Cliente clienteACrear) {
            Cliente clienteCreado = null;
            string sql = "INSERT INTO MAE_CLIENTES VALUES (@Codigo ,@TipoCliente,@TipoDocumento,@NumeroDocumento,@RazonSocial,@ApellidoPaterno,@ApellidoMaterno,@Nombre ,@Sexo,@Direccion,@CodigoUbigeo ,@Telefono,@Correo,@Cuenta,@Saldo)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Codigo", clienteACrear.Codigo));
                    comando.Parameters.Add(new SqlParameter("@TipoCliente", clienteACrear.TipoCliente));
                    comando.Parameters.Add(new SqlParameter("@TipoDocumento", clienteACrear.TipoDocumento));
                    comando.Parameters.Add(new SqlParameter("@NumeroDocumento", clienteACrear.NumeroDocumento));
                    comando.Parameters.Add(new SqlParameter("@RazonSocial", clienteACrear.RazonSocial));
                    comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", clienteACrear.ApellidoPaterno));
                    comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", clienteACrear.ApellidoMaterno));
                    comando.Parameters.Add(new SqlParameter("@Nombre", clienteACrear.Nombre));
                    comando.Parameters.Add(new SqlParameter("@Sexo", clienteACrear.Sexo));
                    comando.Parameters.Add(new SqlParameter("@Direccion", clienteACrear.Direccion));
                    comando.Parameters.Add(new SqlParameter("@CodigoUbigeo", clienteACrear.CodigoUbigeo));
                    comando.Parameters.Add(new SqlParameter("@Telefono", clienteACrear.Telefono));
                    comando.Parameters.Add(new SqlParameter("@Correo", clienteACrear.Correo));
                    comando.Parameters.Add(new SqlParameter("@Cuenta", clienteACrear.Cuenta));
                    comando.Parameters.Add(new SqlParameter("@Saldo", clienteACrear.Saldo));
                    comando.ExecuteNonQuery();
                }
            }
            clienteCreado = Obtener(clienteACrear.Codigo);
            return clienteCreado;
        }

        public Cliente Obtener(string Codigo)
        {
            
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM MAE_CLIENTES WHERE COD_CLI=@Codigo";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())

                        {
                           
                            clienteEncontrado = new Cliente()
                            {
                            
                            Codigo = (string)resultado["COD_CLI"],
                            TipoCliente = (string)resultado["TIP_CLI"],
                            TipoDocumento = (string)resultado["TIP_DOC_IDENT"],
                            NumeroDocumento = (string)resultado["NRO_DOC_IDENT"],
                            RazonSocial = (string)resultado["DES_RAZON_SOCIAL"],
                            ApellidoPaterno = (string)resultado["APE_PATERNO"],
                            ApellidoMaterno = (string)resultado["APE_MATERNO"],
                            Nombre = (string)resultado["NOM_CLIENTE"],
                            Sexo = (string)resultado["TIP_SEXO"],
                            Direccion = (string)resultado["DES_DIRECCION"],
                            CodigoUbigeo = (string)resultado["COD_UBIGEO"],
                            Telefono = (string)resultado["NUM_TELEFONO"],
                            Correo = (string)resultado["DES_EMAIL"],
                            Cuenta = (string)resultado["NUM_CUENTA"],
                            Saldo = (decimal)resultado["IMP_SALDO"]


                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public Cliente Modificar(Cliente clienteAModificar)
        {
            Cliente clienteModificado = null;
            string sql = "UPDATE MAE_CLIENTES SET TIP_CLI=@TipoCliente,TIP_DOC_IDENT=@TipoDocumento,NRO_DOC_IDENT=@NumeroDocumento,DES_RAZON_SOCIAL=@RazonSocial,APE_PATERNO=@ApellidoPaterno,APE_MATERNO=@ApellidoMaterno,NOM_CLIENTE=@Nombre,TIP_SEXO=@Sexo,DES_DIRECCION=@Direccion,COD_UBIGEO=@CodigoUbigeo,NUM_TELEFONO=@Telefono,DES_EMAIL=@Correo,NUM_CUENTA=@Cuenta,IMP_SALDO=@Saldo where COD_CLI=@Codigo";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    
                    comando.Parameters.Add(new SqlParameter("@TipoCliente", clienteAModificar.TipoCliente));
                    comando.Parameters.Add(new SqlParameter("@TipoDocumento", clienteAModificar.TipoDocumento));
                    comando.Parameters.Add(new SqlParameter("@NumeroDocumento", clienteAModificar.NumeroDocumento));
                    comando.Parameters.Add(new SqlParameter("@RazonSocial", clienteAModificar.RazonSocial));
                    comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", clienteAModificar.ApellidoPaterno));
                    comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", clienteAModificar.ApellidoMaterno));
                    comando.Parameters.Add(new SqlParameter("@Nombre", clienteAModificar.Nombre));
                    comando.Parameters.Add(new SqlParameter("@Sexo", clienteAModificar.Sexo));
                    comando.Parameters.Add(new SqlParameter("@Direccion", clienteAModificar.Direccion));
                    comando.Parameters.Add(new SqlParameter("@CodigoUbigeo", clienteAModificar.CodigoUbigeo));
                    comando.Parameters.Add(new SqlParameter("@Telefono", clienteAModificar.Telefono));
                    comando.Parameters.Add(new SqlParameter("@Correo", clienteAModificar.Correo));
                    comando.Parameters.Add(new SqlParameter("@Cuenta", clienteAModificar.Cuenta));
                    comando.Parameters.Add(new SqlParameter("@Saldo", clienteAModificar.Saldo));
                    comando.Parameters.Add(new SqlParameter("@Codigo", clienteAModificar.Codigo));
                    comando.ExecuteNonQuery();
                }
            }
            clienteModificado = Obtener(clienteAModificar.Codigo);
            return clienteModificado;
        }


        public List<Cliente> Listar()
        {
            List<Cliente> clientesEncontrados = new List<Cliente>();
            Cliente clientesEncontrado = null;

            string sql = "SELECT * FROM MAE_CLIENTES";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            clientesEncontrado = new Cliente()
                            {
                                Codigo = (string)resultado["COD_CLI"],
                                TipoCliente = (string)resultado["TIP_CLI"],
                                TipoDocumento = (string)resultado["TIP_DOC_IDENT"],
                                NumeroDocumento = (string)resultado["NRO_DOC_IDENT"],
                                RazonSocial = (string)resultado["DES_RAZON_SOCIAL"],
                                ApellidoPaterno = (string)resultado["APE_PATERNO"],
                                ApellidoMaterno = (string)resultado["APE_MATERNO"],
                                Nombre = (string)resultado["NOM_CLIENTE"],
                                Sexo = (string)resultado["TIP_SEXO"],
                                Direccion = (string)resultado["DES_DIRECCION"],
                                CodigoUbigeo = (string)resultado["COD_UBIGEO"],
                                Telefono = (string)resultado["NUM_TELEFONO"],
                                Correo = (string)resultado["DES_EMAIL"],
                                Cuenta = (string)resultado["NUM_CUENTA"],
                                Saldo = (decimal)resultado["IMP_SALDO"]
                            };
                            clientesEncontrados.Add(clientesEncontrado);
                        }
                    }
                }

            }

            return clientesEncontrados;
        }

    }
}