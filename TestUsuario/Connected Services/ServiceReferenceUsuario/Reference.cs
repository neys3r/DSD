﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestUsuario.ServiceReferenceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoUsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoCliente {
            get {
                return this.CodigoClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoClienteField, value) != true)) {
                    this.CodigoClienteField = value;
                    this.RaisePropertyChanged("CodigoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoUsuario {
            get {
                return this.CodigoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoUsuarioField, value) != true)) {
                    this.CodigoUsuarioField = value;
                    this.RaisePropertyChanged("CodigoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescUsuario {
            get {
                return this.DescUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.DescUsuarioField, value) != true)) {
                    this.DescUsuarioField = value;
                    this.RaisePropertyChanged("DescUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoUsuario {
            get {
                return this.TipoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoUsuarioField, value) != true)) {
                    this.TipoUsuarioField = value;
                    this.RaisePropertyChanged("TipoUsuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.IUsuarios")]
    public interface IUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarios/CrearUsuarioResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestUsuario.ServiceReferenceUsuario.RepetidoException), Action="http://tempuri.org/IUsuarios/CrearUsuarioRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
        TestUsuario.ServiceReferenceUsuario.Usuario CrearUsuario(TestUsuario.ServiceReferenceUsuario.Usuario usuarioACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarios/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> CrearUsuarioAsync(TestUsuario.ServiceReferenceUsuario.Usuario usuarioACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarios/ObtenerUsuarioResponse")]
        TestUsuario.ServiceReferenceUsuario.Usuario ObtenerUsuario(string CodigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarios/ObtenerUsuarioResponse")]
        System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> ObtenerUsuarioAsync(string CodigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ModificarUsuario", ReplyAction="http://tempuri.org/IUsuarios/ModificarUsuarioResponse")]
        TestUsuario.ServiceReferenceUsuario.Usuario ModificarUsuario(TestUsuario.ServiceReferenceUsuario.Usuario usuarioAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ModificarUsuario", ReplyAction="http://tempuri.org/IUsuarios/ModificarUsuarioResponse")]
        System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> ModificarUsuarioAsync(TestUsuario.ServiceReferenceUsuario.Usuario usuarioAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarios/ListarUsuariosResponse")]
        TestUsuario.ServiceReferenceUsuario.Usuario[] ListarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarios/ListarUsuariosResponse")]
        System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario[]> ListarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuariosChannel : TestUsuario.ServiceReferenceUsuario.IUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosClient : System.ServiceModel.ClientBase<TestUsuario.ServiceReferenceUsuario.IUsuarios>, TestUsuario.ServiceReferenceUsuario.IUsuarios {
        
        public UsuariosClient() {
        }
        
        public UsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestUsuario.ServiceReferenceUsuario.Usuario CrearUsuario(TestUsuario.ServiceReferenceUsuario.Usuario usuarioACrear) {
            return base.Channel.CrearUsuario(usuarioACrear);
        }
        
        public System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> CrearUsuarioAsync(TestUsuario.ServiceReferenceUsuario.Usuario usuarioACrear) {
            return base.Channel.CrearUsuarioAsync(usuarioACrear);
        }
        
        public TestUsuario.ServiceReferenceUsuario.Usuario ObtenerUsuario(string CodigoUsuario) {
            return base.Channel.ObtenerUsuario(CodigoUsuario);
        }
        
        public System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> ObtenerUsuarioAsync(string CodigoUsuario) {
            return base.Channel.ObtenerUsuarioAsync(CodigoUsuario);
        }
        
        public TestUsuario.ServiceReferenceUsuario.Usuario ModificarUsuario(TestUsuario.ServiceReferenceUsuario.Usuario usuarioAModificar) {
            return base.Channel.ModificarUsuario(usuarioAModificar);
        }
        
        public System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario> ModificarUsuarioAsync(TestUsuario.ServiceReferenceUsuario.Usuario usuarioAModificar) {
            return base.Channel.ModificarUsuarioAsync(usuarioAModificar);
        }
        
        public TestUsuario.ServiceReferenceUsuario.Usuario[] ListarUsuarios() {
            return base.Channel.ListarUsuarios();
        }
        
        public System.Threading.Tasks.Task<TestUsuario.ServiceReferenceUsuario.Usuario[]> ListarUsuariosAsync() {
            return base.Channel.ListarUsuariosAsync();
        }
    }
}