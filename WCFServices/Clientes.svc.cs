using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Clientes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Clientes.svc o Clientes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Clientes : IClientes
    {
        private ClienteDAO clienteDAO = new ClienteDAO();
        public Cliente CrearCliente(Cliente clienteACrear)
        {
            if (clienteDAO.Obtener(clienteACrear.Codigo) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "El cliente ya existe"
                    }, new FaultReason("Error al intentar creación"));
            }
            return clienteDAO.Crear(clienteACrear);
        }


        public Cliente ObtenerCliente(string Codigo)
        {
            return clienteDAO.Obtener(Codigo);
        }

        public Cliente ModificarCliente(Cliente clienteAModificar)
        {
            return clienteDAO.Modificar(clienteAModificar);
        }

        public List<Cliente> ListarClientes()
        {
            return clienteDAO.Listar();
        }

        public string Neyser()
        {
            return clienteDAO.Neyser();
        }
    }
}
