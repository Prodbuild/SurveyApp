﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrollmentWorkflow.ActionItemManager {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActionItem", Namespace="http://schemas.datacontract.org/2004/07/EnrollmentService.Domain.ActionItem")]
    [System.SerializableAttribute()]
    public partial class ActionItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActionUriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string ActionUri {
            get {
                return this.ActionUriField;
            }
            set {
                if ((object.ReferenceEquals(this.ActionUriField, value) != true)) {
                    this.ActionUriField = value;
                    this.RaisePropertyChanged("ActionUri");
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
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ActionItemManager.IActionItemManager")]
    public interface IActionItemManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForSite", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForSiteResponse")]
        EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForSite(string siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForSite", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForSiteResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForSiteAsync(string siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForPractice", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForPracticeResponse")]
        EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForPractice(long practiceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForPractice", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForPracticeResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForPracticeAsync(long practiceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForPayer", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForPayerResponse")]
        EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForPayer(long practiceId, long payerListId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActionItemManager/GetActionItemsForPayer", ReplyAction="http://tempuri.org/IActionItemManager/GetActionItemsForPayerResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForPayerAsync(long practiceId, long payerListId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IActionItemManagerChannel : EnrollmentWorkflow.ActionItemManager.IActionItemManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ActionItemManagerClient : System.ServiceModel.ClientBase<EnrollmentWorkflow.ActionItemManager.IActionItemManager>, EnrollmentWorkflow.ActionItemManager.IActionItemManager {
        
        public ActionItemManagerClient() {
        }
        
        public ActionItemManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ActionItemManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActionItemManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActionItemManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForSite(string siteId) {
            return base.Channel.GetActionItemsForSite(siteId);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForSiteAsync(string siteId) {
            return base.Channel.GetActionItemsForSiteAsync(siteId);
        }
        
        public EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForPractice(long practiceId) {
            return base.Channel.GetActionItemsForPractice(practiceId);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForPracticeAsync(long practiceId) {
            return base.Channel.GetActionItemsForPracticeAsync(practiceId);
        }
        
        public EnrollmentWorkflow.ActionItemManager.ActionItem[] GetActionItemsForPayer(long practiceId, long payerListId) {
            return base.Channel.GetActionItemsForPayer(practiceId, payerListId);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ActionItemManager.ActionItem[]> GetActionItemsForPayerAsync(long practiceId, long payerListId) {
            return base.Channel.GetActionItemsForPayerAsync(practiceId, payerListId);
        }
    }
}