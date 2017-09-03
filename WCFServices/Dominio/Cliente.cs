using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string TipoCliente { get; set; }
        [DataMember]
        public string TipoDocumento { get; set; }
        [DataMember]
        public string NumeroDocumento { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string CodigoUbigeo { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Cuenta { get; set; }
        [DataMember]
        public decimal Saldo { get; set; }
        

    }
}