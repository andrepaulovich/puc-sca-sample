﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCompositionAgencia.ServiceComponentAereo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformacaoAviaoVO", Namespace="http://schemas.datacontract.org/2004/07/ServicoAereo")]
    [System.SerializableAttribute()]
    public partial class InformacaoAviaoVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServiceCompositionAgencia.ServiceComponentAereo.AssentoAviaoVO[] AssentosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoCidadeDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoCidadeOrigemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
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
        public ServiceCompositionAgencia.ServiceComponentAereo.AssentoAviaoVO[] Assentos {
            get {
                return this.AssentosField;
            }
            set {
                if ((object.ReferenceEquals(this.AssentosField, value) != true)) {
                    this.AssentosField = value;
                    this.RaisePropertyChanged("Assentos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoCidadeDestino {
            get {
                return this.CodigoCidadeDestinoField;
            }
            set {
                if ((this.CodigoCidadeDestinoField.Equals(value) != true)) {
                    this.CodigoCidadeDestinoField = value;
                    this.RaisePropertyChanged("CodigoCidadeDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoCidadeOrigem {
            get {
                return this.CodigoCidadeOrigemField;
            }
            set {
                if ((this.CodigoCidadeOrigemField.Equals(value) != true)) {
                    this.CodigoCidadeOrigemField = value;
                    this.RaisePropertyChanged("CodigoCidadeOrigem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AssentoAviaoVO", Namespace="http://schemas.datacontract.org/2004/07/ServicoAereo")]
    [System.SerializableAttribute()]
    public partial class AssentoAviaoVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileiraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LivreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroField;
        
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
        public string Fileira {
            get {
                return this.FileiraField;
            }
            set {
                if ((object.ReferenceEquals(this.FileiraField, value) != true)) {
                    this.FileiraField = value;
                    this.RaisePropertyChanged("Fileira");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Livre {
            get {
                return this.LivreField;
            }
            set {
                if ((this.LivreField.Equals(value) != true)) {
                    this.LivreField = value;
                    this.RaisePropertyChanged("Livre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((this.NumeroField.Equals(value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservaAviaoVO", Namespace="http://schemas.datacontract.org/2004/07/ServicoAereo")]
    [System.SerializableAttribute()]
    public partial class ReservaAviaoVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AssentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoCidadeDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoCidadeOrigemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileiraField;
        
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
        public int Assento {
            get {
                return this.AssentoField;
            }
            set {
                if ((this.AssentoField.Equals(value) != true)) {
                    this.AssentoField = value;
                    this.RaisePropertyChanged("Assento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoCidadeDestino {
            get {
                return this.CodigoCidadeDestinoField;
            }
            set {
                if ((this.CodigoCidadeDestinoField.Equals(value) != true)) {
                    this.CodigoCidadeDestinoField = value;
                    this.RaisePropertyChanged("CodigoCidadeDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoCidadeOrigem {
            get {
                return this.CodigoCidadeOrigemField;
            }
            set {
                if ((this.CodigoCidadeOrigemField.Equals(value) != true)) {
                    this.CodigoCidadeOrigemField = value;
                    this.RaisePropertyChanged("CodigoCidadeOrigem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fileira {
            get {
                return this.FileiraField;
            }
            set {
                if ((object.ReferenceEquals(this.FileiraField, value) != true)) {
                    this.FileiraField = value;
                    this.RaisePropertyChanged("Fileira");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceComponentAereo.IServiceAereo")]
    public interface IServiceAereo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAereo/VerificarPrecos", ReplyAction="http://tempuri.org/IServiceAereo/VerificarPrecosResponse")]
        ServiceCompositionAgencia.ServiceComponentAereo.InformacaoAviaoVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAereo/VerificarPrecos", ReplyAction="http://tempuri.org/IServiceAereo/VerificarPrecosResponse")]
        System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentAereo.InformacaoAviaoVO> VerificarPrecosAsync(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAereo/ComprarPassagem", ReplyAction="http://tempuri.org/IServiceAereo/ComprarPassagemResponse")]
        ServiceCompositionAgencia.ServiceComponentAereo.ReservaAviaoVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data, int numeroAssento, string fileira);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAereo/ComprarPassagem", ReplyAction="http://tempuri.org/IServiceAereo/ComprarPassagemResponse")]
        System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentAereo.ReservaAviaoVO> ComprarPassagemAsync(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data, int numeroAssento, string fileira);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAereoChannel : global::ServiceCompositionAgencia.ServiceComponentAereo.IServiceAereo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAereoClient : System.ServiceModel.ClientBase<global::ServiceCompositionAgencia.ServiceComponentAereo.IServiceAereo>, global::ServiceCompositionAgencia.ServiceComponentAereo.IServiceAereo {
        
        public ServiceAereoClient() {
        }
        
        public ServiceAereoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAereoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAereoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAereoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceCompositionAgencia.ServiceComponentAereo.InformacaoAviaoVO VerificarPrecos(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data) {
            return base.Channel.VerificarPrecos(codigoCidadeOrigem, codigoCidadeDestino, data);
        }
        
        public System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentAereo.InformacaoAviaoVO> VerificarPrecosAsync(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data) {
            return base.Channel.VerificarPrecosAsync(codigoCidadeOrigem, codigoCidadeDestino, data);
        }
        
        public ServiceCompositionAgencia.ServiceComponentAereo.ReservaAviaoVO ComprarPassagem(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data, int numeroAssento, string fileira) {
            return base.Channel.ComprarPassagem(codigoCidadeOrigem, codigoCidadeDestino, data, numeroAssento, fileira);
        }
        
        public System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentAereo.ReservaAviaoVO> ComprarPassagemAsync(int codigoCidadeOrigem, int codigoCidadeDestino, System.DateTime data, int numeroAssento, string fileira) {
            return base.Channel.ComprarPassagemAsync(codigoCidadeOrigem, codigoCidadeDestino, data, numeroAssento, fileira);
        }
    }
}
