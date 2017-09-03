using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Asesor
    {
        [DataMember]
        public int Dni { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Estado { get; set; }

    }
}