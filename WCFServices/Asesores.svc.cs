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
    public class Asesores : IAsesores
    {
        //Prueba comentario

        private AsesorDAO asesorDAO = new AsesorDAO();
        public Asesor CrearAsesor(Asesor asesorACrear)
        {
            if(asesorDAO.Obtener(asesorACrear.Dni) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "El asesor ya existe"
                    }, new FaultReason("Error al intentar creación"));
            }
            return asesorDAO.Crear(asesorACrear);
        }

        public Asesor ObtenerAsesor(int dni)
        {
            return asesorDAO.Obtener(dni);
        }

        public Asesor ModificarAsesor(Asesor asesorAModificar)
        {
            return asesorDAO.Modificar(asesorAModificar);
        }

        public void EliminarAsesor(int dni)
        {
            asesorDAO.Eliminar(dni);
        }

        public List<Asesor> ListarAsesores()
        {
            return asesorDAO.Listar();
        }

        public string Americo(string nombre)
        {
            return nombre;
        }

       
    }
}
