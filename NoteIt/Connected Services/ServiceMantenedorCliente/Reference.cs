﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoteIt.ServiceMantenedorCliente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorCliente.WebServiceMantenedorClienteSoap")]
    public interface WebServiceMantenedorClienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webGuardarCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webGuardarCliente(NoteIt.ServiceMantenedorCliente.Transacciones transacciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webGuardarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task webGuardarClienteAsync(NoteIt.ServiceMantenedorCliente.Transacciones transacciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webEliminarCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webEliminarCliente(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webEliminarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task webEliminarClienteAsync(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webActualizarCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void webActualizarCliente(NoteIt.ServiceMantenedorCliente.Transacciones transacciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webActualizarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task webActualizarClienteAsync(NoteIt.ServiceMantenedorCliente.Transacciones transacciones);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webListarCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet webListarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webListarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> webListarClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webBuscarCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NoteIt.ServiceMantenedorCliente.Transacciones webBuscarCliente(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webBuscarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<NoteIt.ServiceMantenedorCliente.Transacciones> webBuscarClienteAsync(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webPosicionCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NoteIt.ServiceMantenedorCliente.Transacciones webPosicionCliente(int fila);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/webPosicionCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<NoteIt.ServiceMantenedorCliente.Transacciones> webPosicionClienteAsync(int fila);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Transacciones : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string rutField;
        
        private string nombreField;
        
        private string notasField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("Rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Notas {
            get {
                return this.notasField;
            }
            set {
                this.notasField = value;
                this.RaisePropertyChanged("Notas");
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
    public interface WebServiceMantenedorClienteSoapChannel : NoteIt.ServiceMantenedorCliente.WebServiceMantenedorClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceMantenedorClienteSoapClient : System.ServiceModel.ClientBase<NoteIt.ServiceMantenedorCliente.WebServiceMantenedorClienteSoap>, NoteIt.ServiceMantenedorCliente.WebServiceMantenedorClienteSoap {
        
        public WebServiceMantenedorClienteSoapClient() {
        }
        
        public WebServiceMantenedorClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceMantenedorClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMantenedorClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMantenedorClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void webGuardarCliente(NoteIt.ServiceMantenedorCliente.Transacciones transacciones) {
            base.Channel.webGuardarCliente(transacciones);
        }
        
        public System.Threading.Tasks.Task webGuardarClienteAsync(NoteIt.ServiceMantenedorCliente.Transacciones transacciones) {
            return base.Channel.webGuardarClienteAsync(transacciones);
        }
        
        public void webEliminarCliente(string rut) {
            base.Channel.webEliminarCliente(rut);
        }
        
        public System.Threading.Tasks.Task webEliminarClienteAsync(string rut) {
            return base.Channel.webEliminarClienteAsync(rut);
        }
        
        public void webActualizarCliente(NoteIt.ServiceMantenedorCliente.Transacciones transacciones) {
            base.Channel.webActualizarCliente(transacciones);
        }
        
        public System.Threading.Tasks.Task webActualizarClienteAsync(NoteIt.ServiceMantenedorCliente.Transacciones transacciones) {
            return base.Channel.webActualizarClienteAsync(transacciones);
        }
        
        public System.Data.DataSet webListarCliente() {
            return base.Channel.webListarCliente();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> webListarClienteAsync() {
            return base.Channel.webListarClienteAsync();
        }
        
        public NoteIt.ServiceMantenedorCliente.Transacciones webBuscarCliente(string rut) {
            return base.Channel.webBuscarCliente(rut);
        }
        
        public System.Threading.Tasks.Task<NoteIt.ServiceMantenedorCliente.Transacciones> webBuscarClienteAsync(string rut) {
            return base.Channel.webBuscarClienteAsync(rut);
        }
        
        public NoteIt.ServiceMantenedorCliente.Transacciones webPosicionCliente(int fila) {
            return base.Channel.webPosicionCliente(fila);
        }
        
        public System.Threading.Tasks.Task<NoteIt.ServiceMantenedorCliente.Transacciones> webPosicionClienteAsync(int fila) {
            return base.Channel.webPosicionClienteAsync(fila);
        }
    }
}