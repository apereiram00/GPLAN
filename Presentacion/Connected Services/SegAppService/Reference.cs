﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.SegAppService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WebService.Modelos")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Presentacion.SegAppService.Perfil[] PerfilesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioJSONField;
        
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
        public int CodigoOperacion {
            get {
                return this.CodigoOperacionField;
            }
            set {
                if ((this.CodigoOperacionField.Equals(value) != true)) {
                    this.CodigoOperacionField = value;
                    this.RaisePropertyChanged("CodigoOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeOperacion {
            get {
                return this.MensajeOperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeOperacionField, value) != true)) {
                    this.MensajeOperacionField = value;
                    this.RaisePropertyChanged("MensajeOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Presentacion.SegAppService.Perfil[] Perfiles {
            get {
                return this.PerfilesField;
            }
            set {
                if ((object.ReferenceEquals(this.PerfilesField, value) != true)) {
                    this.PerfilesField = value;
                    this.RaisePropertyChanged("Perfiles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioJSON {
            get {
                return this.UsuarioJSONField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioJSONField, value) != true)) {
                    this.UsuarioJSONField = value;
                    this.RaisePropertyChanged("UsuarioJSON");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Perfil", Namespace="http://schemas.datacontract.org/2004/07/WebService.Modelos")]
    [System.SerializableAttribute()]
    public partial class Perfil : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionPerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IdPerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Presentacion.SegAppService.Operacion[] OperacionesField;
        
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
        public string DescripcionPerfil {
            get {
                return this.DescripcionPerfilField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionPerfilField, value) != true)) {
                    this.DescripcionPerfilField = value;
                    this.RaisePropertyChanged("DescripcionPerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal IdPerfil {
            get {
                return this.IdPerfilField;
            }
            set {
                if ((this.IdPerfilField.Equals(value) != true)) {
                    this.IdPerfilField = value;
                    this.RaisePropertyChanged("IdPerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombrePerfil {
            get {
                return this.NombrePerfilField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePerfilField, value) != true)) {
                    this.NombrePerfilField = value;
                    this.RaisePropertyChanged("NombrePerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Presentacion.SegAppService.Operacion[] Operaciones {
            get {
                return this.OperacionesField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacionesField, value) != true)) {
                    this.OperacionesField = value;
                    this.RaisePropertyChanged("Operaciones");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Operacion", Namespace="http://schemas.datacontract.org/2004/07/WebService.Modelos")]
    [System.SerializableAttribute()]
    public partial class Operacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IdOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreOperacionField;
        
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
        public string DescripcionOperacion {
            get {
                return this.DescripcionOperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionOperacionField, value) != true)) {
                    this.DescripcionOperacionField = value;
                    this.RaisePropertyChanged("DescripcionOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal IdOperacion {
            get {
                return this.IdOperacionField;
            }
            set {
                if ((this.IdOperacionField.Equals(value) != true)) {
                    this.IdOperacionField = value;
                    this.RaisePropertyChanged("IdOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreOperacion {
            get {
                return this.NombreOperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreOperacionField, value) != true)) {
                    this.NombreOperacionField = value;
                    this.RaisePropertyChanged("NombreOperacion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SegAppService.ISegApp")]
    public interface ISegApp {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/Authenticate", ReplyAction="http://tempuri.org/ISegApp/AuthenticateResponse")]
        Presentacion.SegAppService.Usuario Authenticate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/Authenticate", ReplyAction="http://tempuri.org/ISegApp/AuthenticateResponse")]
        System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthenticateWithData", ReplyAction="http://tempuri.org/ISegApp/AuthenticateWithDataResponse")]
        Presentacion.SegAppService.Usuario AuthenticateWithData(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthenticateWithData", ReplyAction="http://tempuri.org/ISegApp/AuthenticateWithDataResponse")]
        System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateWithDataAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthenticateWithDataJSON", ReplyAction="http://tempuri.org/ISegApp/AuthenticateWithDataJSONResponse")]
        Presentacion.SegAppService.Usuario AuthenticateWithDataJSON(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthenticateWithDataJSON", ReplyAction="http://tempuri.org/ISegApp/AuthenticateWithDataJSONResponse")]
        System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateWithDataJSONAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/GetGruposByUsername", ReplyAction="http://tempuri.org/ISegApp/GetGruposByUsernameResponse")]
        string[] GetGruposByUsername(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/GetGruposByUsername", ReplyAction="http://tempuri.org/ISegApp/GetGruposByUsernameResponse")]
        System.Threading.Tasks.Task<string[]> GetGruposByUsernameAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/EsMiembroDe", ReplyAction="http://tempuri.org/ISegApp/EsMiembroDeResponse")]
        bool EsMiembroDe(string username, string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/EsMiembroDe", ReplyAction="http://tempuri.org/ISegApp/EsMiembroDeResponse")]
        System.Threading.Tasks.Task<bool> EsMiembroDeAsync(string username, string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/Authorizate", ReplyAction="http://tempuri.org/ISegApp/AuthorizateResponse")]
        Presentacion.SegAppService.Usuario Authorizate(string username, decimal idAplicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/Authorizate", ReplyAction="http://tempuri.org/ISegApp/AuthorizateResponse")]
        System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthorizateAsync(string username, decimal idAplicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthorizateJSON", ReplyAction="http://tempuri.org/ISegApp/AuthorizateJSONResponse")]
        Presentacion.SegAppService.Usuario AuthorizateJSON(string username, decimal idAplicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegApp/AuthorizateJSON", ReplyAction="http://tempuri.org/ISegApp/AuthorizateJSONResponse")]
        System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthorizateJSONAsync(string username, decimal idAplicacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISegAppChannel : Presentacion.SegAppService.ISegApp, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SegAppClient : System.ServiceModel.ClientBase<Presentacion.SegAppService.ISegApp>, Presentacion.SegAppService.ISegApp {
        
        public SegAppClient() {
        }
        
        public SegAppClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SegAppClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SegAppClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SegAppClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Presentacion.SegAppService.Usuario Authenticate(string username, string password) {
            return base.Channel.Authenticate(username, password);
        }
        
        public System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateAsync(string username, string password) {
            return base.Channel.AuthenticateAsync(username, password);
        }
        
        public Presentacion.SegAppService.Usuario AuthenticateWithData(string username, string password) {
            return base.Channel.AuthenticateWithData(username, password);
        }
        
        public System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateWithDataAsync(string username, string password) {
            return base.Channel.AuthenticateWithDataAsync(username, password);
        }
        
        public Presentacion.SegAppService.Usuario AuthenticateWithDataJSON(string username, string password) {
            return base.Channel.AuthenticateWithDataJSON(username, password);
        }
        
        public System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthenticateWithDataJSONAsync(string username, string password) {
            return base.Channel.AuthenticateWithDataJSONAsync(username, password);
        }
        
        public string[] GetGruposByUsername(string user) {
            return base.Channel.GetGruposByUsername(user);
        }
        
        public System.Threading.Tasks.Task<string[]> GetGruposByUsernameAsync(string user) {
            return base.Channel.GetGruposByUsernameAsync(user);
        }
        
        public bool EsMiembroDe(string username, string groupname) {
            return base.Channel.EsMiembroDe(username, groupname);
        }
        
        public System.Threading.Tasks.Task<bool> EsMiembroDeAsync(string username, string groupname) {
            return base.Channel.EsMiembroDeAsync(username, groupname);
        }
        
        public Presentacion.SegAppService.Usuario Authorizate(string username, decimal idAplicacion) {
            return base.Channel.Authorizate(username, idAplicacion);
        }
        
        public System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthorizateAsync(string username, decimal idAplicacion) {
            return base.Channel.AuthorizateAsync(username, idAplicacion);
        }
        
        public Presentacion.SegAppService.Usuario AuthorizateJSON(string username, decimal idAplicacion) {
            return base.Channel.AuthorizateJSON(username, idAplicacion);
        }
        
        public System.Threading.Tasks.Task<Presentacion.SegAppService.Usuario> AuthorizateJSONAsync(string username, decimal idAplicacion) {
            return base.Channel.AuthorizateJSONAsync(username, idAplicacion);
        }
    }
}
