﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCompositionAgencia.ServiceComponentHotel {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformacaoQuartosVO", Namespace="http://schemas.datacontract.org/2004/07/ServiceHotel")]
    [System.SerializableAttribute()]
    public partial class InformacaoQuartosVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoHotelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServiceCompositionAgencia.ServiceComponentHotel.QuartoVO[] QuartosField;
        
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
        public int CodigoHotel {
            get {
                return this.CodigoHotelField;
            }
            set {
                if ((this.CodigoHotelField.Equals(value) != true)) {
                    this.CodigoHotelField = value;
                    this.RaisePropertyChanged("CodigoHotel");
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
        public ServiceCompositionAgencia.ServiceComponentHotel.QuartoVO[] Quartos {
            get {
                return this.QuartosField;
            }
            set {
                if ((object.ReferenceEquals(this.QuartosField, value) != true)) {
                    this.QuartosField = value;
                    this.RaisePropertyChanged("Quartos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="QuartoVO", Namespace="http://schemas.datacontract.org/2004/07/ServiceHotel")]
    [System.SerializableAttribute()]
    public partial class QuartoVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HidromassagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TelevisaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VistaField;
        
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
        public bool Hidromassagem {
            get {
                return this.HidromassagemField;
            }
            set {
                if ((this.HidromassagemField.Equals(value) != true)) {
                    this.HidromassagemField = value;
                    this.RaisePropertyChanged("Hidromassagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Televisao {
            get {
                return this.TelevisaoField;
            }
            set {
                if ((this.TelevisaoField.Equals(value) != true)) {
                    this.TelevisaoField = value;
                    this.RaisePropertyChanged("Televisao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Vista {
            get {
                return this.VistaField;
            }
            set {
                if ((this.VistaField.Equals(value) != true)) {
                    this.VistaField = value;
                    this.RaisePropertyChanged("Vista");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservaVO", Namespace="http://schemas.datacontract.org/2004/07/ServiceHotel")]
    [System.SerializableAttribute()]
    public partial class ReservaVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServiceCompositionAgencia.ServiceComponentHotel.QuartoVO QuartoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RealizadoField;
        
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
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceCompositionAgencia.ServiceComponentHotel.QuartoVO Quarto {
            get {
                return this.QuartoField;
            }
            set {
                if ((object.ReferenceEquals(this.QuartoField, value) != true)) {
                    this.QuartoField = value;
                    this.RaisePropertyChanged("Quarto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Realizado {
            get {
                return this.RealizadoField;
            }
            set {
                if ((this.RealizadoField.Equals(value) != true)) {
                    this.RealizadoField = value;
                    this.RaisePropertyChanged("Realizado");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceComponentHotel.IServiceHotel")]
    public interface IServiceHotel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHotel/VerificarQuartos", ReplyAction="http://tempuri.org/IServiceHotel/VerificarQuartosResponse")]
        ServiceCompositionAgencia.ServiceComponentHotel.InformacaoQuartosVO VerificarQuartos(int codigoHotel, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHotel/VerificarQuartos", ReplyAction="http://tempuri.org/IServiceHotel/VerificarQuartosResponse")]
        System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentHotel.InformacaoQuartosVO> VerificarQuartosAsync(int codigoHotel, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHotel/ReservarQuarto", ReplyAction="http://tempuri.org/IServiceHotel/ReservarQuartoResponse")]
        ServiceCompositionAgencia.ServiceComponentHotel.ReservaVO ReservarQuarto(int codigoHotel, string nome, System.DateTime data, int codigoTipoQuarto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHotel/ReservarQuarto", ReplyAction="http://tempuri.org/IServiceHotel/ReservarQuartoResponse")]
        System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentHotel.ReservaVO> ReservarQuartoAsync(int codigoHotel, string nome, System.DateTime data, int codigoTipoQuarto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHotelChannel : global::ServiceCompositionAgencia.ServiceComponentHotel.IServiceHotel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHotelClient : System.ServiceModel.ClientBase<global::ServiceCompositionAgencia.ServiceComponentHotel.IServiceHotel>, global::ServiceCompositionAgencia.ServiceComponentHotel.IServiceHotel {
        
        public ServiceHotelClient() {
        }
        
        public ServiceHotelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceHotelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHotelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHotelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceCompositionAgencia.ServiceComponentHotel.InformacaoQuartosVO VerificarQuartos(int codigoHotel, System.DateTime data) {
            return base.Channel.VerificarQuartos(codigoHotel, data);
        }
        
        public System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentHotel.InformacaoQuartosVO> VerificarQuartosAsync(int codigoHotel, System.DateTime data) {
            return base.Channel.VerificarQuartosAsync(codigoHotel, data);
        }
        
        public ServiceCompositionAgencia.ServiceComponentHotel.ReservaVO ReservarQuarto(int codigoHotel, string nome, System.DateTime data, int codigoTipoQuarto) {
            return base.Channel.ReservarQuarto(codigoHotel, nome, data, codigoTipoQuarto);
        }
        
        public System.Threading.Tasks.Task<ServiceCompositionAgencia.ServiceComponentHotel.ReservaVO> ReservarQuartoAsync(int codigoHotel, string nome, System.DateTime data, int codigoTipoQuarto) {
            return base.Channel.ReservarQuartoAsync(codigoHotel, nome, data, codigoTipoQuarto);
        }
    }
}
