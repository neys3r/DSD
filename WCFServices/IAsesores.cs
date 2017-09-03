using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;

namespace WCFServices
{
    [ServiceContract]
    public interface IAsesores
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Asesor CrearAsesor(Asesor asesorACrear);

        [OperationContract]
        Asesor ObtenerAsesor(int dni);
        [OperationContract]
        Asesor ModificarAsesor(Asesor asesorAModificar);
        [OperationContract]
        void EliminarAsesor(int dni);

        [OperationContract]
        List<Asesor> ListarAsesores();

        [OperationContract]
        string Americo(string nombre);

        
    }
}
