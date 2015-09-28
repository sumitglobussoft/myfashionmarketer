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

namespace SocioboardDataScheduler.Api.LinkedinAccount {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="LinkedinAccountSoap", Namespace="http://tempuri.org/")]
    public partial class LinkedinAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UserInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllLinkedinAccountsOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLinkedinAccountDetailsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteLinkedinAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllLinkedinAccountsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LinkedinAccount() {
            this.Url = global::SocioboardDataScheduler.Properties.Settings.Default.SocioboardDataScheduler_Api_LinkedinAccount_LinkedinAccount;
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
        public event UserInformationCompletedEventHandler UserInformationCompleted;
        
        /// <remarks/>
        public event GetAllLinkedinAccountsOfUserCompletedEventHandler GetAllLinkedinAccountsOfUserCompleted;
        
        /// <remarks/>
        public event GetLinkedinAccountDetailsByIdCompletedEventHandler GetLinkedinAccountDetailsByIdCompleted;
        
        /// <remarks/>
        public event DeleteLinkedinAccountCompletedEventHandler DeleteLinkedinAccountCompleted;
        
        /// <remarks/>
        public event GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventHandler GetAllLinkedinAccountsByUserIdAndGroupIdCompleted;
        
        /// <remarks/>
        public event GetAllLinkedinAccountsCompletedEventHandler GetAllLinkedinAccountsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UserInformation(string UserId, string LinkedinId) {
            object[] results = this.Invoke("UserInformation", new object[] {
                        UserId,
                        LinkedinId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UserInformationAsync(string UserId, string LinkedinId) {
            this.UserInformationAsync(UserId, LinkedinId, null);
        }
        
        /// <remarks/>
        public void UserInformationAsync(string UserId, string LinkedinId, object userState) {
            if ((this.UserInformationOperationCompleted == null)) {
                this.UserInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserInformationOperationCompleted);
            }
            this.InvokeAsync("UserInformation", new object[] {
                        UserId,
                        LinkedinId}, this.UserInformationOperationCompleted, userState);
        }
        
        private void OnUserInformationOperationCompleted(object arg) {
            if ((this.UserInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UserInformationCompleted(this, new UserInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllLinkedinAccountsOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllLinkedinAccountsOfUser(string UserId) {
            object[] results = this.Invoke("GetAllLinkedinAccountsOfUser", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsOfUserAsync(string UserId) {
            this.GetAllLinkedinAccountsOfUserAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsOfUserAsync(string UserId, object userState) {
            if ((this.GetAllLinkedinAccountsOfUserOperationCompleted == null)) {
                this.GetAllLinkedinAccountsOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllLinkedinAccountsOfUserOperationCompleted);
            }
            this.InvokeAsync("GetAllLinkedinAccountsOfUser", new object[] {
                        UserId}, this.GetAllLinkedinAccountsOfUserOperationCompleted, userState);
        }
        
        private void OnGetAllLinkedinAccountsOfUserOperationCompleted(object arg) {
            if ((this.GetAllLinkedinAccountsOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllLinkedinAccountsOfUserCompleted(this, new GetAllLinkedinAccountsOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetLinkedinAccountDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLinkedinAccountDetailsById(string UserId, string LinkedinId) {
            object[] results = this.Invoke("GetLinkedinAccountDetailsById", new object[] {
                        UserId,
                        LinkedinId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetLinkedinAccountDetailsByIdAsync(string UserId, string LinkedinId) {
            this.GetLinkedinAccountDetailsByIdAsync(UserId, LinkedinId, null);
        }
        
        /// <remarks/>
        public void GetLinkedinAccountDetailsByIdAsync(string UserId, string LinkedinId, object userState) {
            if ((this.GetLinkedinAccountDetailsByIdOperationCompleted == null)) {
                this.GetLinkedinAccountDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLinkedinAccountDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetLinkedinAccountDetailsById", new object[] {
                        UserId,
                        LinkedinId}, this.GetLinkedinAccountDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetLinkedinAccountDetailsByIdOperationCompleted(object arg) {
            if ((this.GetLinkedinAccountDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLinkedinAccountDetailsByIdCompleted(this, new GetLinkedinAccountDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteLinkedinAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteLinkedinAccount(string UserId, string ProfileId, string GroupId) {
            object[] results = this.Invoke("DeleteLinkedinAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteLinkedinAccountAsync(string UserId, string ProfileId, string GroupId) {
            this.DeleteLinkedinAccountAsync(UserId, ProfileId, GroupId, null);
        }
        
        /// <remarks/>
        public void DeleteLinkedinAccountAsync(string UserId, string ProfileId, string GroupId, object userState) {
            if ((this.DeleteLinkedinAccountOperationCompleted == null)) {
                this.DeleteLinkedinAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteLinkedinAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteLinkedinAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId}, this.DeleteLinkedinAccountOperationCompleted, userState);
        }
        
        private void OnDeleteLinkedinAccountOperationCompleted(object arg) {
            if ((this.DeleteLinkedinAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteLinkedinAccountCompleted(this, new DeleteLinkedinAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllLinkedinAccountsByUserIdAndGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllLinkedinAccountsByUserIdAndGroupId(string userid, string groupid) {
            object[] results = this.Invoke("GetAllLinkedinAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsByUserIdAndGroupIdAsync(string userid, string groupid) {
            this.GetAllLinkedinAccountsByUserIdAndGroupIdAsync(userid, groupid, null);
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsByUserIdAndGroupIdAsync(string userid, string groupid, object userState) {
            if ((this.GetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted == null)) {
                this.GetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetAllLinkedinAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid}, this.GetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted, userState);
        }
        
        private void OnGetAllLinkedinAccountsByUserIdAndGroupIdOperationCompleted(object arg) {
            if ((this.GetAllLinkedinAccountsByUserIdAndGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllLinkedinAccountsByUserIdAndGroupIdCompleted(this, new GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllLinkedinAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllLinkedinAccounts() {
            object[] results = this.Invoke("GetAllLinkedinAccounts", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsAsync() {
            this.GetAllLinkedinAccountsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllLinkedinAccountsAsync(object userState) {
            if ((this.GetAllLinkedinAccountsOperationCompleted == null)) {
                this.GetAllLinkedinAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllLinkedinAccountsOperationCompleted);
            }
            this.InvokeAsync("GetAllLinkedinAccounts", new object[0], this.GetAllLinkedinAccountsOperationCompleted, userState);
        }
        
        private void OnGetAllLinkedinAccountsOperationCompleted(object arg) {
            if ((this.GetAllLinkedinAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllLinkedinAccountsCompleted(this, new GetAllLinkedinAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void UserInformationCompletedEventHandler(object sender, UserInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UserInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UserInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllLinkedinAccountsOfUserCompletedEventHandler(object sender, GetAllLinkedinAccountsOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllLinkedinAccountsOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllLinkedinAccountsOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetLinkedinAccountDetailsByIdCompletedEventHandler(object sender, GetLinkedinAccountDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLinkedinAccountDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLinkedinAccountDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteLinkedinAccountCompletedEventHandler(object sender, DeleteLinkedinAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteLinkedinAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteLinkedinAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventHandler(object sender, GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllLinkedinAccountsByUserIdAndGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllLinkedinAccountsCompletedEventHandler(object sender, GetAllLinkedinAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllLinkedinAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllLinkedinAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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