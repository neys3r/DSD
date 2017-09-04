using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUsuario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {

            ServiceReferenceUsuario.UsuariosClient proxy = new ServiceReferenceUsuario.UsuariosClient();
            ServiceReferenceUsuario.Usuario usuarioCreado = proxy.CrearUsuario(new ServiceReferenceUsuario.Usuario()
            {
                CodigoUsuario = "11",
                DescUsuario = "Usuario11",
                TipoUsuario = "1",
                Contrasena = "Contrasena11",
                CodigoCliente = "02",
                Estado = false
            });
            Assert.AreEqual("11", usuarioCreado.CodigoUsuario);
            Assert.AreEqual("Usuario11", usuarioCreado.DescUsuario);
            Assert.AreEqual("1", usuarioCreado.TipoUsuario);
            Assert.AreEqual("Contrasena11", usuarioCreado.Contrasena);
            Assert.AreEqual("02", usuarioCreado.CodigoCliente);
            Assert.AreEqual(false, usuarioCreado.Estado);

        }
    }
}
