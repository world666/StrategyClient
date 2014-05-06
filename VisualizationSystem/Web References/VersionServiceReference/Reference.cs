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

namespace VisualizationSystem.VersionServiceReference {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IVersionService", Namespace="http://tempuri.org/")]
    public partial class VersionService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetActualVersionOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyUserAppVersionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public VersionService() {
            this.Url = "http://109.254.14.106/WCF/versions.svc";
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
        public event GetActualVersionCompletedEventHandler GetActualVersionCompleted;
        
        /// <remarks/>
        public event VerifyUserAppVersionCompletedEventHandler VerifyUserAppVersionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IVersionService/GetActualVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetActualVersion() {
            object[] results = this.Invoke("GetActualVersion", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetActualVersionAsync() {
            this.GetActualVersionAsync(null);
        }
        
        /// <remarks/>
        public void GetActualVersionAsync(object userState) {
            if ((this.GetActualVersionOperationCompleted == null)) {
                this.GetActualVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActualVersionOperationCompleted);
            }
            this.InvokeAsync("GetActualVersion", new object[0], this.GetActualVersionOperationCompleted, userState);
        }
        
        private void OnGetActualVersionOperationCompleted(object arg) {
            if ((this.GetActualVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActualVersionCompleted(this, new GetActualVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IVersionService/VerifyUserAppVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VerifyUserAppVersion([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string userAppVersion, out VersionState VerifyUserAppVersionResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool VerifyUserAppVersionResultSpecified) {
            object[] results = this.Invoke("VerifyUserAppVersion", new object[] {
                        userAppVersion});
            VerifyUserAppVersionResult = ((VersionState)(results[0]));
            VerifyUserAppVersionResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void VerifyUserAppVersionAsync(string userAppVersion) {
            this.VerifyUserAppVersionAsync(userAppVersion, null);
        }
        
        /// <remarks/>
        public void VerifyUserAppVersionAsync(string userAppVersion, object userState) {
            if ((this.VerifyUserAppVersionOperationCompleted == null)) {
                this.VerifyUserAppVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyUserAppVersionOperationCompleted);
            }
            this.InvokeAsync("VerifyUserAppVersion", new object[] {
                        userAppVersion}, this.VerifyUserAppVersionOperationCompleted, userState);
        }
        
        private void OnVerifyUserAppVersionOperationCompleted(object arg) {
            if ((this.VerifyUserAppVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyUserAppVersionCompleted(this, new VerifyUserAppVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public enum VersionState {
        
        /// <remarks/>
        Actual,
        
        /// <remarks/>
        OutDated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetActualVersionCompletedEventHandler(object sender, GetActualVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActualVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActualVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void VerifyUserAppVersionCompletedEventHandler(object sender, VerifyUserAppVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyUserAppVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyUserAppVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public VersionState VerifyUserAppVersionResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((VersionState)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool VerifyUserAppVersionResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591