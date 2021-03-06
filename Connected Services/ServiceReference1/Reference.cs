﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shipping.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCFCost")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPayable")]
    public interface IPayable {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetCost", ReplyAction="http://tempuri.org/IPayable/GetCostResponse")]
        double GetCost(string company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetCost", ReplyAction="http://tempuri.org/IPayable/GetCostResponse")]
        System.Threading.Tasks.Task<double> GetCostAsync(string company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetOvernight", ReplyAction="http://tempuri.org/IPayable/GetOvernightResponse")]
        double GetOvernight();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetOvernight", ReplyAction="http://tempuri.org/IPayable/GetOvernightResponse")]
        System.Threading.Tasks.Task<double> GetOvernightAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetFlatFee", ReplyAction="http://tempuri.org/IPayable/GetFlatFeeResponse")]
        double GetFlatFee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetFlatFee", ReplyAction="http://tempuri.org/IPayable/GetFlatFeeResponse")]
        System.Threading.Tasks.Task<double> GetFlatFeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPayable/GetDataUsingDataContractResponse")]
        Shipping.ServiceReference1.CompositeType GetDataUsingDataContract(Shipping.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPayable/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPayable/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Shipping.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Shipping.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPayableChannel : Shipping.ServiceReference1.IPayable, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PayableClient : System.ServiceModel.ClientBase<Shipping.ServiceReference1.IPayable>, Shipping.ServiceReference1.IPayable {
        
        public PayableClient() {
        }
        
        public PayableClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PayableClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PayableClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PayableClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetCost(string company) {
            return base.Channel.GetCost(company);
        }
        
        public System.Threading.Tasks.Task<double> GetCostAsync(string company) {
            return base.Channel.GetCostAsync(company);
        }
        
        public double GetOvernight() {
            return base.Channel.GetOvernight();
        }
        
        public System.Threading.Tasks.Task<double> GetOvernightAsync() {
            return base.Channel.GetOvernightAsync();
        }
        
        public double GetFlatFee() {
            return base.Channel.GetFlatFee();
        }
        
        public System.Threading.Tasks.Task<double> GetFlatFeeAsync() {
            return base.Channel.GetFlatFeeAsync();
        }
        
        public Shipping.ServiceReference1.CompositeType GetDataUsingDataContract(Shipping.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Shipping.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Shipping.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
