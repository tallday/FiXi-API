﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiXiAPIsamples.TeamService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTeamDetailsRequest", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class GetTeamDetailsRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FiXiAPIsamples.TeamService.MarkMessageAsReadResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FiXiAPIsamples.TeamService.GetTeamDetailsByIdListResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(FiXiAPIsamples.TeamService.GetTeamDetailsResponse))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MarkMessageAsReadResponse", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class MarkMessageAsReadResponse : FiXiAPIsamples.TeamService.ResponseBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTeamDetailsByIdListResponse", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class GetTeamDetailsByIdListResponse : FiXiAPIsamples.TeamService.ResponseBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.TeamDetailView[] TeamDetailViewListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.TeamDetailView[] TeamDetailViewList {
            get {
                return this.TeamDetailViewListField;
            }
            set {
                if ((object.ReferenceEquals(this.TeamDetailViewListField, value) != true)) {
                    this.TeamDetailViewListField = value;
                    this.RaisePropertyChanged("TeamDetailViewList");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTeamDetailsResponse", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class GetTeamDetailsResponse : FiXiAPIsamples.TeamService.ResponseBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.TeamDetailView TeamDetailViewField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.TeamDetailView TeamDetailView {
            get {
                return this.TeamDetailViewField;
            }
            set {
                if ((object.ReferenceEquals(this.TeamDetailViewField, value) != true)) {
                    this.TeamDetailViewField = value;
                    this.RaisePropertyChanged("TeamDetailView");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TeamDetailView", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class TeamDetailView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DiscountRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.DiscountTypeEnum DiscountTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.CustomerAsPlayerView[] PlayerViewListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.StatusEnum StatusField;
        
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
        public decimal Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DiscountRate {
            get {
                return this.DiscountRateField;
            }
            set {
                if ((this.DiscountRateField.Equals(value) != true)) {
                    this.DiscountRateField = value;
                    this.RaisePropertyChanged("DiscountRate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.DiscountTypeEnum DiscountType {
            get {
                return this.DiscountTypeField;
            }
            set {
                if ((this.DiscountTypeField.Equals(value) != true)) {
                    this.DiscountTypeField = value;
                    this.RaisePropertyChanged("DiscountType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modified {
            get {
                return this.ModifiedField;
            }
            set {
                if ((this.ModifiedField.Equals(value) != true)) {
                    this.ModifiedField = value;
                    this.RaisePropertyChanged("Modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.CustomerAsPlayerView[] PlayerViewList {
            get {
                return this.PlayerViewListField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerViewListField, value) != true)) {
                    this.PlayerViewListField = value;
                    this.RaisePropertyChanged("PlayerViewList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.StatusEnum Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DiscountTypeEnum", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    public enum DiscountTypeEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Percentage = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Currency = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoDiscount = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerAsPlayerView", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class CustomerAsPlayerView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FiXiAPIsamples.TeamService.PlayerRoleEnum RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShirtNumberField;
        
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
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modified {
            get {
                return this.ModifiedField;
            }
            set {
                if ((this.ModifiedField.Equals(value) != true)) {
                    this.ModifiedField = value;
                    this.RaisePropertyChanged("Modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FiXiAPIsamples.TeamService.PlayerRoleEnum Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShirtNumber {
            get {
                return this.ShirtNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ShirtNumberField, value) != true)) {
                    this.ShirtNumberField = value;
                    this.RaisePropertyChanged("ShirtNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusEnum", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    public enum StatusEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerRoleEnum", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    public enum PlayerRoleEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Coach = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PlayerCoach = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Captain = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Player = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Contact = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ViceCaptain = 6,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClearMessageAsReadRequest", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class ClearMessageAsReadRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TeamIDField;
        
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
        public int TeamID {
            get {
                return this.TeamIDField;
            }
            set {
                if ((this.TeamIDField.Equals(value) != true)) {
                    this.TeamIDField = value;
                    this.RaisePropertyChanged("TeamID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTeamDetailsByIdListRequest", Namespace="http://schemas.datacontract.org/2004/07/FiXi.DataContract")]
    [System.SerializableAttribute()]
    public partial class GetTeamDetailsByIdListRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] TeamIdListField;
        
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
        public int[] TeamIdList {
            get {
                return this.TeamIdListField;
            }
            set {
                if ((object.ReferenceEquals(this.TeamIdListField, value) != true)) {
                    this.TeamIdListField = value;
                    this.RaisePropertyChanged("TeamIdList");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://FiXi.Contracts/PrivateServices", ConfigurationName="TeamService.ITeamService")]
    public interface ITeamService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://FiXi.Contracts/PrivateServices/ITeamService/GetTeamDetails", ReplyAction="http://FiXi.Contracts/PrivateServices/ITeamService/GetTeamDetailsResponse")]
        FiXiAPIsamples.TeamService.GetTeamDetailsResponse GetTeamDetails(FiXiAPIsamples.TeamService.GetTeamDetailsRequest GetTeamDetailsRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://FiXi.Contracts/PrivateServices/ITeamService/MarkMessageAsRead", ReplyAction="http://FiXi.Contracts/PrivateServices/ITeamService/MarkMessageAsReadResponse")]
        FiXiAPIsamples.TeamService.MarkMessageAsReadResponse MarkMessageAsRead(FiXiAPIsamples.TeamService.ClearMessageAsReadRequest MarkMessageAsReadRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://FiXi.Contracts/PrivateServices/ITeamService/GetTeamDetailsByIdList", ReplyAction="http://FiXi.Contracts/PrivateServices/ITeamService/GetTeamDetailsByIdListResponse" +
            "")]
        FiXiAPIsamples.TeamService.GetTeamDetailsByIdListResponse GetTeamDetailsByIdList(FiXiAPIsamples.TeamService.GetTeamDetailsByIdListRequest GetTeamDetailsByIdListRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITeamServiceChannel : FiXiAPIsamples.TeamService.ITeamService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TeamServiceClient : System.ServiceModel.ClientBase<FiXiAPIsamples.TeamService.ITeamService>, FiXiAPIsamples.TeamService.ITeamService {
        
        public TeamServiceClient() {
        }
        
        public TeamServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TeamServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeamServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeamServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FiXiAPIsamples.TeamService.GetTeamDetailsResponse GetTeamDetails(FiXiAPIsamples.TeamService.GetTeamDetailsRequest GetTeamDetailsRequest) {
            return base.Channel.GetTeamDetails(GetTeamDetailsRequest);
        }
        
        public FiXiAPIsamples.TeamService.MarkMessageAsReadResponse MarkMessageAsRead(FiXiAPIsamples.TeamService.ClearMessageAsReadRequest MarkMessageAsReadRequest) {
            return base.Channel.MarkMessageAsRead(MarkMessageAsReadRequest);
        }
        
        public FiXiAPIsamples.TeamService.GetTeamDetailsByIdListResponse GetTeamDetailsByIdList(FiXiAPIsamples.TeamService.GetTeamDetailsByIdListRequest GetTeamDetailsByIdListRequest) {
            return base.Channel.GetTeamDetailsByIdList(GetTeamDetailsByIdListRequest);
        }
    }
}
