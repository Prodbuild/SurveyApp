﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrollmentWorkflow.ProviderManager {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Provider", Namespace="http://schemas.datacontract.org/2004/07/EnrollmentService.Domain.Provider")]
    [System.SerializableAttribute()]
    public partial class Provider : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IndividualRenderingNpiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleInitialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteFirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteIndividualRenderingNpiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteMiddleInitialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteSpecialtyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteTaxIdOrSsnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialtyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaxIdOrSsnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IndividualRenderingNpi {
            get {
                return this.IndividualRenderingNpiField;
            }
            set {
                if ((object.ReferenceEquals(this.IndividualRenderingNpiField, value) != true)) {
                    this.IndividualRenderingNpiField = value;
                    this.RaisePropertyChanged("IndividualRenderingNpi");
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
        public string MiddleInitial {
            get {
                return this.MiddleInitialField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleInitialField, value) != true)) {
                    this.MiddleInitialField = value;
                    this.RaisePropertyChanged("MiddleInitial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteFirstName {
            get {
                return this.NoteFirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteFirstNameField, value) != true)) {
                    this.NoteFirstNameField = value;
                    this.RaisePropertyChanged("NoteFirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteIndividualRenderingNpi {
            get {
                return this.NoteIndividualRenderingNpiField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteIndividualRenderingNpiField, value) != true)) {
                    this.NoteIndividualRenderingNpiField = value;
                    this.RaisePropertyChanged("NoteIndividualRenderingNpi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteLastName {
            get {
                return this.NoteLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteLastNameField, value) != true)) {
                    this.NoteLastNameField = value;
                    this.RaisePropertyChanged("NoteLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteMiddleInitial {
            get {
                return this.NoteMiddleInitialField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteMiddleInitialField, value) != true)) {
                    this.NoteMiddleInitialField = value;
                    this.RaisePropertyChanged("NoteMiddleInitial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteSpecialty {
            get {
                return this.NoteSpecialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteSpecialtyField, value) != true)) {
                    this.NoteSpecialtyField = value;
                    this.RaisePropertyChanged("NoteSpecialty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteTaxIdOrSsn {
            get {
                return this.NoteTaxIdOrSsnField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteTaxIdOrSsnField, value) != true)) {
                    this.NoteTaxIdOrSsnField = value;
                    this.RaisePropertyChanged("NoteTaxIdOrSsn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoteTitle {
            get {
                return this.NoteTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteTitleField, value) != true)) {
                    this.NoteTitleField = value;
                    this.RaisePropertyChanged("NoteTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialty {
            get {
                return this.SpecialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialtyField, value) != true)) {
                    this.SpecialtyField = value;
                    this.RaisePropertyChanged("Specialty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaxIdOrSsn {
            get {
                return this.TaxIdOrSsnField;
            }
            set {
                if ((object.ReferenceEquals(this.TaxIdOrSsnField, value) != true)) {
                    this.TaxIdOrSsnField = value;
                    this.RaisePropertyChanged("TaxIdOrSsn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProviderNotes", Namespace="http://schemas.datacontract.org/2004/07/EnrollmentService.Domain.Provider")]
    [System.SerializableAttribute()]
    public partial class ProviderNotes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IndividualRenderingNpiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleInitialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialtyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaxIdOrSsnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IndividualRenderingNpi {
            get {
                return this.IndividualRenderingNpiField;
            }
            set {
                if ((object.ReferenceEquals(this.IndividualRenderingNpiField, value) != true)) {
                    this.IndividualRenderingNpiField = value;
                    this.RaisePropertyChanged("IndividualRenderingNpi");
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
        public string MiddleInitial {
            get {
                return this.MiddleInitialField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleInitialField, value) != true)) {
                    this.MiddleInitialField = value;
                    this.RaisePropertyChanged("MiddleInitial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialty {
            get {
                return this.SpecialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialtyField, value) != true)) {
                    this.SpecialtyField = value;
                    this.RaisePropertyChanged("Specialty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaxIdOrSsn {
            get {
                return this.TaxIdOrSsnField;
            }
            set {
                if ((object.ReferenceEquals(this.TaxIdOrSsnField, value) != true)) {
                    this.TaxIdOrSsnField = value;
                    this.RaisePropertyChanged("TaxIdOrSsn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Specialty", Namespace="http://schemas.datacontract.org/2004/07/EnrollmentService.Domain.Provider")]
    [System.SerializableAttribute()]
    public partial class Specialty : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProviderManager.IProviderManager")]
    public interface IProviderManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProvider", ReplyAction="http://tempuri.org/IProviderManager/AddProviderResponse")]
        void AddProvider(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProvider", ReplyAction="http://tempuri.org/IProviderManager/AddProviderResponse")]
        System.Threading.Tasks.Task AddProviderAsync(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProviderNotes", ReplyAction="http://tempuri.org/IProviderManager/AddProviderNotesResponse")]
        void AddProviderNotes(EnrollmentWorkflow.ProviderManager.ProviderNotes providerNotesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProviderNotes", ReplyAction="http://tempuri.org/IProviderManager/AddProviderNotesResponse")]
        System.Threading.Tasks.Task AddProviderNotesAsync(EnrollmentWorkflow.ProviderManager.ProviderNotes providerNotesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProviderPracticeCrosswalk", ReplyAction="http://tempuri.org/IProviderManager/AddProviderPracticeCrosswalkResponse")]
        void AddProviderPracticeCrosswalk(string siteId, long providerId, long[] practiceIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/AddProviderPracticeCrosswalk", ReplyAction="http://tempuri.org/IProviderManager/AddProviderPracticeCrosswalkResponse")]
        System.Threading.Tasks.Task AddProviderPracticeCrosswalkAsync(string siteId, long providerId, long[] practiceIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/UpdateProvider", ReplyAction="http://tempuri.org/IProviderManager/UpdateProviderResponse")]
        void UpdateProvider(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/UpdateProvider", ReplyAction="http://tempuri.org/IProviderManager/UpdateProviderResponse")]
        System.Threading.Tasks.Task UpdateProviderAsync(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/RemoveProvider", ReplyAction="http://tempuri.org/IProviderManager/RemoveProviderResponse")]
        void RemoveProvider(string siteId, int providerId, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/RemoveProvider", ReplyAction="http://tempuri.org/IProviderManager/RemoveProviderResponse")]
        System.Threading.Tasks.Task RemoveProviderAsync(string siteId, int providerId, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProviders", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersResponse")]
        EnrollmentWorkflow.ProviderManager.Provider[] GetProviders(string siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProviders", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersAsync(string siteId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProvidersForPractice", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersForPracticeResponse")]
        EnrollmentWorkflow.ProviderManager.Provider[] GetProvidersForPractice(long practiceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProvidersForPractice", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersForPracticeResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersForPracticeAsync(long practiceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProvidersForProviderIds", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersForProviderIdsResponse")]
        EnrollmentWorkflow.ProviderManager.Provider[] GetProvidersForProviderIds(int[] providerIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProvidersForProviderIds", ReplyAction="http://tempuri.org/IProviderManager/GetProvidersForProviderIdsResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersForProviderIdsAsync(int[] providerIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProviderPracticeInfoForProviderId", ReplyAction="http://tempuri.org/IProviderManager/GetProviderPracticeInfoForProviderIdResponse")]
        long[] GetProviderPracticeInfoForProviderId(long providerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetProviderPracticeInfoForProviderId", ReplyAction="http://tempuri.org/IProviderManager/GetProviderPracticeInfoForProviderIdResponse")]
        System.Threading.Tasks.Task<long[]> GetProviderPracticeInfoForProviderIdAsync(long providerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetSpecialtyList", ReplyAction="http://tempuri.org/IProviderManager/GetSpecialtyListResponse")]
        EnrollmentWorkflow.ProviderManager.Specialty[] GetSpecialtyList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProviderManager/GetSpecialtyList", ReplyAction="http://tempuri.org/IProviderManager/GetSpecialtyListResponse")]
        System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Specialty[]> GetSpecialtyListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProviderManagerChannel : EnrollmentWorkflow.ProviderManager.IProviderManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderManagerClient : System.ServiceModel.ClientBase<EnrollmentWorkflow.ProviderManager.IProviderManager>, EnrollmentWorkflow.ProviderManager.IProviderManager {
        
        public ProviderManagerClient() {
        }
        
        public ProviderManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProviderManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProviderManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProviderManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddProvider(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName) {
            base.Channel.AddProvider(siteId, providerInfo, practiceIds, userName);
        }
        
        public System.Threading.Tasks.Task AddProviderAsync(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName) {
            return base.Channel.AddProviderAsync(siteId, providerInfo, practiceIds, userName);
        }
        
        public void AddProviderNotes(EnrollmentWorkflow.ProviderManager.ProviderNotes providerNotesInfo) {
            base.Channel.AddProviderNotes(providerNotesInfo);
        }
        
        public System.Threading.Tasks.Task AddProviderNotesAsync(EnrollmentWorkflow.ProviderManager.ProviderNotes providerNotesInfo) {
            return base.Channel.AddProviderNotesAsync(providerNotesInfo);
        }
        
        public void AddProviderPracticeCrosswalk(string siteId, long providerId, long[] practiceIds) {
            base.Channel.AddProviderPracticeCrosswalk(siteId, providerId, practiceIds);
        }
        
        public System.Threading.Tasks.Task AddProviderPracticeCrosswalkAsync(string siteId, long providerId, long[] practiceIds) {
            return base.Channel.AddProviderPracticeCrosswalkAsync(siteId, providerId, practiceIds);
        }
        
        public void UpdateProvider(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName) {
            base.Channel.UpdateProvider(siteId, providerInfo, practiceIds, userName);
        }
        
        public System.Threading.Tasks.Task UpdateProviderAsync(string siteId, EnrollmentWorkflow.ProviderManager.Provider providerInfo, long[] practiceIds, string userName) {
            return base.Channel.UpdateProviderAsync(siteId, providerInfo, practiceIds, userName);
        }
        
        public void RemoveProvider(string siteId, int providerId, string userName) {
            base.Channel.RemoveProvider(siteId, providerId, userName);
        }
        
        public System.Threading.Tasks.Task RemoveProviderAsync(string siteId, int providerId, string userName) {
            return base.Channel.RemoveProviderAsync(siteId, providerId, userName);
        }
        
        public EnrollmentWorkflow.ProviderManager.Provider[] GetProviders(string siteId) {
            return base.Channel.GetProviders(siteId);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersAsync(string siteId) {
            return base.Channel.GetProvidersAsync(siteId);
        }
        
        public EnrollmentWorkflow.ProviderManager.Provider[] GetProvidersForPractice(long practiceId) {
            return base.Channel.GetProvidersForPractice(practiceId);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersForPracticeAsync(long practiceId) {
            return base.Channel.GetProvidersForPracticeAsync(practiceId);
        }
        
        public EnrollmentWorkflow.ProviderManager.Provider[] GetProvidersForProviderIds(int[] providerIds) {
            return base.Channel.GetProvidersForProviderIds(providerIds);
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Provider[]> GetProvidersForProviderIdsAsync(int[] providerIds) {
            return base.Channel.GetProvidersForProviderIdsAsync(providerIds);
        }
        
        public long[] GetProviderPracticeInfoForProviderId(long providerId) {
            return base.Channel.GetProviderPracticeInfoForProviderId(providerId);
        }
        
        public System.Threading.Tasks.Task<long[]> GetProviderPracticeInfoForProviderIdAsync(long providerId) {
            return base.Channel.GetProviderPracticeInfoForProviderIdAsync(providerId);
        }
        
        public EnrollmentWorkflow.ProviderManager.Specialty[] GetSpecialtyList() {
            return base.Channel.GetSpecialtyList();
        }
        
        public System.Threading.Tasks.Task<EnrollmentWorkflow.ProviderManager.Specialty[]> GetSpecialtyListAsync() {
            return base.Channel.GetSpecialtyListAsync();
        }
    }
}
