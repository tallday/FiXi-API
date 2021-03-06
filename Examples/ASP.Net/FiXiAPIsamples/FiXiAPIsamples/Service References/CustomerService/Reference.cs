﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiXiAPIsamples.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveCustomerAttendanceRequest", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class SaveCustomerAttendanceRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AttendedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CalendarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TeamIdField;
        
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
        public System.Guid ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Attended {
            get {
                return this.AttendedField;
            }
            set {
                if ((this.AttendedField.Equals(value) != true)) {
                    this.AttendedField = value;
                    this.RaisePropertyChanged("Attended");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CalendarId {
            get {
                return this.CalendarIdField;
            }
            set {
                if ((this.CalendarIdField.Equals(value) != true)) {
                    this.CalendarIdField = value;
                    this.RaisePropertyChanged("CalendarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TeamId {
            get {
                return this.TeamIdField;
            }
            set {
                if ((this.TeamIdField.Equals(value) != true)) {
                    this.TeamIdField = value;
                    this.RaisePropertyChanged("TeamId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseBase", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceListResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceResponse))]
    public partial class ResponseBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveCustomerAttendanceListResponse", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class SaveCustomerAttendanceListResponse : FiXiAPIsamples.CustomerService.ResponseBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveCustomerAttendanceResponse", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class SaveCustomerAttendanceResponse : FiXiAPIsamples.CustomerService.ResponseBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SaveCustomerAttendanceListRequest", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class SaveCustomerAttendanceListRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.CustomerService.Attendance[] AttendanceListField;
        
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
        public System.Guid ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.CustomerService.Attendance[] AttendanceList {
            get {
                return this.AttendanceListField;
            }
            set {
                if ((object.ReferenceEquals(this.AttendanceListField, value) != true)) {
                    this.AttendanceListField = value;
                    this.RaisePropertyChanged("AttendanceList");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Attendance", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class Attendance : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AttendedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CalendarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TeamIdField;
        
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
        public bool Attended {
            get {
                return this.AttendedField;
            }
            set {
                if ((this.AttendedField.Equals(value) != true)) {
                    this.AttendedField = value;
                    this.RaisePropertyChanged("Attended");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CalendarId {
            get {
                return this.CalendarIdField;
            }
            set {
                if ((this.CalendarIdField.Equals(value) != true)) {
                    this.CalendarIdField = value;
                    this.RaisePropertyChanged("CalendarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TeamId {
            get {
                return this.TeamIdField;
            }
            set {
                if ((this.TeamIdField.Equals(value) != true)) {
                    this.TeamIdField = value;
                    this.RaisePropertyChanged("TeamId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://FiXi.Contracts/PrivateServices", ConfigurationName="CustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://FiXi.Contracts/PrivateServices/ICustomerService/SaveCustomerAttendance", ReplyAction="http://FiXi.Contracts/PrivateServices/ICustomerService/SaveCustomerAttendanceResp" +
            "onse")]
        FiXiAPIsamples.CustomerService.SaveCustomerAttendanceResponse SaveCustomerAttendance(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceRequest SaveCustomerAttendanceRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://FiXi.Contracts/PrivateServices/ICustomerService/SaveCustomerAttendanceList" +
            "", ReplyAction="http://FiXi.Contracts/PrivateServices/ICustomerService/SaveCustomerAttendanceList" +
            "Response")]
        FiXiAPIsamples.CustomerService.SaveCustomerAttendanceListResponse SaveCustomerAttendanceList(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceListRequest SaveCustomerAttendanceRequestList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : FiXiAPIsamples.CustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<FiXiAPIsamples.CustomerService.ICustomerService>, FiXiAPIsamples.CustomerService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FiXiAPIsamples.CustomerService.SaveCustomerAttendanceResponse SaveCustomerAttendance(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceRequest SaveCustomerAttendanceRequest) {
            return base.Channel.SaveCustomerAttendance(SaveCustomerAttendanceRequest);
        }
        
        public FiXiAPIsamples.CustomerService.SaveCustomerAttendanceListResponse SaveCustomerAttendanceList(FiXiAPIsamples.CustomerService.SaveCustomerAttendanceListRequest SaveCustomerAttendanceRequestList) {
            return base.Channel.SaveCustomerAttendanceList(SaveCustomerAttendanceRequestList);
        }
    }
}
