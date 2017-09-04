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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Usuarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Usuarios.svc o Usuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Usuarios : IUsuarios
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        public Usuario CrearUsuario(Usuario usuarioACrear)
        {
            if (usuarioDAO.Obtener(usuarioACrear.CodigoUsuario) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "01",
                        Descripcion = "El usuario ya existe"
                    }, new FaultReason("Error al intentar crear el usuario"));
            }
            return usuarioDAO.Crear(usuarioACrear);
        }


        public Usuario ObtenerUsuario(string CodigoUsuario)
        {
            return usuarioDAO.Obtener(CodigoUsuario);
        }

        public Usuario ModificarUsuario(Usuario usuarioAModificar)
        {
            return usuarioDAO.Modificar(usuarioAModificar);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioDAO.Listar();
        }
    }
}
