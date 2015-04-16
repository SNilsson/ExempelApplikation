﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Umea.se.ExempelApplikation.Utilities.Exce" +
        "ptions")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.ErrorCodes CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.ErrorCodes Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogId {
            get {
                return this.LogIdField;
            }
            set {
                if ((object.ReferenceEquals(this.LogIdField, value) != true)) {
                    this.LogIdField = value;
                    this.RaisePropertyChanged("LogId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorCodes", Namespace="http://schemas.datacontract.org/2004/07/Umea.se.ExempelApplikation.Utilities.Exce" +
        "ptions")]
    public enum ErrorCodes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Exception = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LogicValidationException = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecurityException = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SqlException = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HemortServiceTier.IHemortService")]
    public interface IHemortService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetCountries", ReplyAction="http://tempuri.org/IHemortService/GetCountriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.Error), Action="http://tempuri.org/IHemortService/GetCountriesErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Umea.se.ExempelApplikation.Utilities.Exce" +
            "ptions")]
        System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Country> GetCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetCountries", ReplyAction="http://tempuri.org/IHemortService/GetCountriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Country>> GetCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetHomes", ReplyAction="http://tempuri.org/IHemortService/GetHomesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.Error), Action="http://tempuri.org/IHemortService/GetHomesErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Umea.se.ExempelApplikation.Utilities.Exce" +
            "ptions")]
        System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home> GetHomes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetHomes", ReplyAction="http://tempuri.org/IHemortService/GetHomesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home>> GetHomesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetHomesByCountryId", ReplyAction="http://tempuri.org/IHemortService/GetHomesByCountryIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.Error), Action="http://tempuri.org/IHemortService/GetHomesByCountryIdErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Umea.se.ExempelApplikation.Utilities.Exce" +
            "ptions")]
        System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home> GetHomesByCountryId(int countryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHemortService/GetHomesByCountryId", ReplyAction="http://tempuri.org/IHemortService/GetHomesByCountryIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home>> GetHomesByCountryIdAsync(int countryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHemortServiceChannel : Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.IHemortService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HemortServiceClient : System.ServiceModel.ClientBase<Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.IHemortService>, Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier.IHemortService {
        
        public HemortServiceClient() {
        }
        
        public HemortServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HemortServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HemortServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HemortServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Country> GetCountries() {
            return base.Channel.GetCountries();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Country>> GetCountriesAsync() {
            return base.Channel.GetCountriesAsync();
        }
        
        public System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home> GetHomes() {
            return base.Channel.GetHomes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home>> GetHomesAsync() {
            return base.Channel.GetHomesAsync();
        }
        
        public System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home> GetHomesByCountryId(int countryId) {
            return base.Channel.GetHomesByCountryId(countryId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Umea.se.ExempelApplikation.DataObjectLibrary.Home>> GetHomesByCountryIdAsync(int countryId) {
            return base.Channel.GetHomesByCountryIdAsync(countryId);
        }
    }
}
