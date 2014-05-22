﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace VisualizationSystem.WebReference5 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IBusinessService", Namespace="http://tempuri.org/")]
    public partial class BusinessService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetBusinessesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BusinessService() {
            this.Url = "http://192.168.1.103/WCF/businesses.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetBusinessesCompletedEventHandler GetBusinessesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBusinessService/GetBusinesses", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/DataRepository.Models")]
        public Business[] GetBusinesses(Language lang, [System.Xml.Serialization.XmlIgnoreAttribute()] bool langSpecified, int regionId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool regionIdSpecified) {
            object[] results = this.Invoke("GetBusinesses", new object[] {
                        lang,
                        langSpecified,
                        regionId,
                        regionIdSpecified});
            return ((Business[])(results[0]));
        }
        
        /// <remarks/>
        public void GetBusinessesAsync(Language lang, bool langSpecified, int regionId, bool regionIdSpecified) {
            this.GetBusinessesAsync(lang, langSpecified, regionId, regionIdSpecified, null);
        }
        
        /// <remarks/>
        public void GetBusinessesAsync(Language lang, bool langSpecified, int regionId, bool regionIdSpecified, object userState) {
            if ((this.GetBusinessesOperationCompleted == null)) {
                this.GetBusinessesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBusinessesOperationCompleted);
            }
            this.InvokeAsync("GetBusinesses", new object[] {
                        lang,
                        langSpecified,
                        regionId,
                        regionIdSpecified}, this.GetBusinessesOperationCompleted, userState);
        }
        
        private void OnGetBusinessesOperationCompleted(object arg) {
            if ((this.GetBusinessesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBusinessesCompleted(this, new GetBusinessesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/DataRepository.Models")]
    public enum Language {
        
        /// <remarks/>
        English,
        
        /// <remarks/>
        Russian,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/DataRepository.Models")]
    public partial class Business {
        
        private string businessesNamesField;
        
        private string[] businessesNamesListField;
        
        private string descriptionsField;
        
        private string[] descriptionsListField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private Region regionField;
        
        private int regionIdField;
        
        private bool regionIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BusinessesNames {
            get {
                return this.businessesNamesField;
            }
            set {
                this.businessesNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] BusinessesNamesList {
            get {
                return this.businessesNamesListField;
            }
            set {
                this.businessesNamesListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Descriptions {
            get {
                return this.descriptionsField;
            }
            set {
                this.descriptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] DescriptionsList {
            get {
                return this.descriptionsListField;
            }
            set {
                this.descriptionsListField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Region Region {
            get {
                return this.regionField;
            }
            set {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        public int RegionId {
            get {
                return this.regionIdField;
            }
            set {
                this.regionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegionIdSpecified {
            get {
                return this.regionIdFieldSpecified;
            }
            set {
                this.regionIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/DataRepository.Models")]
    public partial class Region {
        
        private Business[] businessesField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string regionsNamesField;
        
        private string[] regionsNamesListField;
        
        private State stateField;
        
        private int stateIdField;
        
        private bool stateIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Business[] Businesses {
            get {
                return this.businessesField;
            }
            set {
                this.businessesField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string RegionsNames {
            get {
                return this.regionsNamesField;
            }
            set {
                this.regionsNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] RegionsNamesList {
            get {
                return this.regionsNamesListField;
            }
            set {
                this.regionsNamesListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public State State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public int StateId {
            get {
                return this.stateIdField;
            }
            set {
                this.stateIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StateIdSpecified {
            get {
                return this.stateIdFieldSpecified;
            }
            set {
                this.stateIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/DataRepository.Models")]
    public partial class State {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private Region[] regionsField;
        
        private string statesNamesField;
        
        private string[] statesNamesListField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Region[] Regions {
            get {
                return this.regionsField;
            }
            set {
                this.regionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StatesNames {
            get {
                return this.statesNamesField;
            }
            set {
                this.statesNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] StatesNamesList {
            get {
                return this.statesNamesListField;
            }
            set {
                this.statesNamesListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetBusinessesCompletedEventHandler(object sender, GetBusinessesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBusinessesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBusinessesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Business[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Business[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591