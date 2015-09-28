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

namespace SocioboardDataServices.Api.SentimentalAnalysis {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SentimentalAnalysisSoap", Namespace="http://tempuri.org/")]
    public partial class SentimentalAnalysis : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback updateAssignedStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback getNegativeFeedsOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTicketsofGroupOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SentimentalAnalysis() {
            this.Url = global::SocioboardDataServices.Properties.Settings.Default.SocioboardDataServices_Api_SentimentalAnalysis_SentimentalAnalysis;
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
        public event updateAssignedStatusCompletedEventHandler updateAssignedStatusCompleted;
        
        /// <remarks/>
        public event getNegativeFeedsOfUserCompletedEventHandler getNegativeFeedsOfUserCompleted;
        
        /// <remarks/>
        public event GetTicketsofGroupCompletedEventHandler GetTicketsofGroupCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateAssignedStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string updateAssignedStatus(string Id, string AssignedUserId) {
            object[] results = this.Invoke("updateAssignedStatus", new object[] {
                        Id,
                        AssignedUserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateAssignedStatusAsync(string Id, string AssignedUserId) {
            this.updateAssignedStatusAsync(Id, AssignedUserId, null);
        }
        
        /// <remarks/>
        public void updateAssignedStatusAsync(string Id, string AssignedUserId, object userState) {
            if ((this.updateAssignedStatusOperationCompleted == null)) {
                this.updateAssignedStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateAssignedStatusOperationCompleted);
            }
            this.InvokeAsync("updateAssignedStatus", new object[] {
                        Id,
                        AssignedUserId}, this.updateAssignedStatusOperationCompleted, userState);
        }
        
        private void OnupdateAssignedStatusOperationCompleted(object arg) {
            if ((this.updateAssignedStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateAssignedStatusCompleted(this, new updateAssignedStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getNegativeFeedsOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getNegativeFeedsOfUser(string UserId) {
            object[] results = this.Invoke("getNegativeFeedsOfUser", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getNegativeFeedsOfUserAsync(string UserId) {
            this.getNegativeFeedsOfUserAsync(UserId, null);
        }
        
        /// <remarks/>
        public void getNegativeFeedsOfUserAsync(string UserId, object userState) {
            if ((this.getNegativeFeedsOfUserOperationCompleted == null)) {
                this.getNegativeFeedsOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetNegativeFeedsOfUserOperationCompleted);
            }
            this.InvokeAsync("getNegativeFeedsOfUser", new object[] {
                        UserId}, this.getNegativeFeedsOfUserOperationCompleted, userState);
        }
        
        private void OngetNegativeFeedsOfUserOperationCompleted(object arg) {
            if ((this.getNegativeFeedsOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getNegativeFeedsOfUserCompleted(this, new getNegativeFeedsOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTicketsofGroup", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTicketsofGroup(string GroupId, string UserId) {
            object[] results = this.Invoke("GetTicketsofGroup", new object[] {
                        GroupId,
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTicketsofGroupAsync(string GroupId, string UserId) {
            this.GetTicketsofGroupAsync(GroupId, UserId, null);
        }
        
        /// <remarks/>
        public void GetTicketsofGroupAsync(string GroupId, string UserId, object userState) {
            if ((this.GetTicketsofGroupOperationCompleted == null)) {
                this.GetTicketsofGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTicketsofGroupOperationCompleted);
            }
            this.InvokeAsync("GetTicketsofGroup", new object[] {
                        GroupId,
                        UserId}, this.GetTicketsofGroupOperationCompleted, userState);
        }
        
        private void OnGetTicketsofGroupOperationCompleted(object arg) {
            if ((this.GetTicketsofGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTicketsofGroupCompleted(this, new GetTicketsofGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void updateAssignedStatusCompletedEventHandler(object sender, updateAssignedStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateAssignedStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateAssignedStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getNegativeFeedsOfUserCompletedEventHandler(object sender, getNegativeFeedsOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getNegativeFeedsOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getNegativeFeedsOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTicketsofGroupCompletedEventHandler(object sender, GetTicketsofGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTicketsofGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTicketsofGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591