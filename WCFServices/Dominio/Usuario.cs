using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    public class Usuario
    {

        [DataMember]
        public string CodigoUsuario { get; set; }
        [DataMember]
        public string DescUsuario { get; set; }
        [DataMember]
        public string TipoUsuario { get; set; }
        [DataMember]
        public string Contrasena { get; set; }
        [DataMember]
        public string CodigoCliente { get; set; }
        [DataMember]
        public bool Estado { get; set; }


    }
}