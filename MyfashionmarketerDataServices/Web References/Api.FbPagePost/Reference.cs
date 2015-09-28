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

namespace SocioboardDataServices.Api.FbPagePost {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="FbPagePostSoap", Namespace="http://tempuri.org/")]
    public partial class FbPagePost : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPostDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllPostOfPageOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsPostExistOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddPostDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateFbPagePostStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FbPagePost() {
            this.Url = global::SocioboardDataServices.Properties.Settings.Default.SocioboardDataServices_Api_FbPagePost_FbPagePost;
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
        public event GetPostDetailsCompletedEventHandler GetPostDetailsCompleted;
        
        /// <remarks/>
        public event GetAllPostOfPageCompletedEventHandler GetAllPostOfPageCompleted;
        
        /// <remarks/>
        public event IsPostExistCompletedEventHandler IsPostExistCompleted;
        
        /// <remarks/>
        public event AddPostDetailsCompletedEventHandler AddPostDetailsCompleted;
        
        /// <remarks/>
        public event UpdateFbPagePostStatusCompletedEventHandler UpdateFbPagePostStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPostDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPostDetails(string postid) {
            object[] results = this.Invoke("GetPostDetails", new object[] {
                        postid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPostDetailsAsync(string postid) {
            this.GetPostDetailsAsync(postid, null);
        }
        
        /// <remarks/>
        public void GetPostDetailsAsync(string postid, object userState) {
            if ((this.GetPostDetailsOperationCompleted == null)) {
                this.GetPostDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPostDetailsOperationCompleted);
            }
            this.InvokeAsync("GetPostDetails", new object[] {
                        postid}, this.GetPostDetailsOperationCompleted, userState);
        }
        
        private void OnGetPostDetailsOperationCompleted(object arg) {
            if ((this.GetPostDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPostDetailsCompleted(this, new GetPostDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllPostOfPage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllPostOfPage(string profileid, string userid) {
            object[] results = this.Invoke("GetAllPostOfPage", new object[] {
                        profileid,
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllPostOfPageAsync(string profileid, string userid) {
            this.GetAllPostOfPageAsync(profileid, userid, null);
        }
        
        /// <remarks/>
        public void GetAllPostOfPageAsync(string profileid, string userid, object userState) {
            if ((this.GetAllPostOfPageOperationCompleted == null)) {
                this.GetAllPostOfPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllPostOfPageOperationCompleted);
            }
            this.InvokeAsync("GetAllPostOfPage", new object[] {
                        profileid,
                        userid}, this.GetAllPostOfPageOperationCompleted, userState);
        }
        
        private void OnGetAllPostOfPageOperationCompleted(object arg) {
            if ((this.GetAllPostOfPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllPostOfPageCompleted(this, new GetAllPostOfPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IsPostExist", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsPostExist(string jdata) {
            object[] results = this.Invoke("IsPostExist", new object[] {
                        jdata});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IsPostExistAsync(string jdata) {
            this.IsPostExistAsync(jdata, null);
        }
        
        /// <remarks/>
        public void IsPostExistAsync(string jdata, object userState) {
            if ((this.IsPostExistOperationCompleted == null)) {
                this.IsPostExistOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsPostExistOperationCompleted);
            }
            this.InvokeAsync("IsPostExist", new object[] {
                        jdata}, this.IsPostExistOperationCompleted, userState);
        }
        
        private void OnIsPostExistOperationCompleted(object arg) {
            if ((this.IsPostExistCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsPostExistCompleted(this, new IsPostExistCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddPostDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddPostDetails(string jdata) {
            object[] results = this.Invoke("AddPostDetails", new object[] {
                        jdata});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddPostDetailsAsync(string jdata) {
            this.AddPostDetailsAsync(jdata, null);
        }
        
        /// <remarks/>
        public void AddPostDetailsAsync(string jdata, object userState) {
            if ((this.AddPostDetailsOperationCompleted == null)) {
                this.AddPostDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddPostDetailsOperationCompleted);
            }
            this.InvokeAsync("AddPostDetails", new object[] {
                        jdata}, this.AddPostDetailsOperationCompleted, userState);
        }
        
        private void OnAddPostDetailsOperationCompleted(object arg) {
            if ((this.AddPostDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddPostDetailsCompleted(this, new AddPostDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateFbPagePostStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateFbPagePostStatus(string jdata) {
            object[] results = this.Invoke("UpdateFbPagePostStatus", new object[] {
                        jdata});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateFbPagePostStatusAsync(string jdata) {
            this.UpdateFbPagePostStatusAsync(jdata, null);
        }
        
        /// <remarks/>
        public void UpdateFbPagePostStatusAsync(string jdata, object userState) {
            if ((this.UpdateFbPagePostStatusOperationCompleted == null)) {
                this.UpdateFbPagePostStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateFbPagePostStatusOperationCompleted);
            }
            this.InvokeAsync("UpdateFbPagePostStatus", new object[] {
                        jdata}, this.UpdateFbPagePostStatusOperationCompleted, userState);
        }
        
        private void OnUpdateFbPagePostStatusOperationCompleted(object arg) {
            if ((this.UpdateFbPagePostStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateFbPagePostStatusCompleted(this, new UpdateFbPagePostStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetPostDetailsCompletedEventHandler(object sender, GetPostDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPostDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPostDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllPostOfPageCompletedEventHandler(object sender, GetAllPostOfPageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllPostOfPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllPostOfPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void IsPostExistCompletedEventHandler(object sender, IsPostExistCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsPostExistCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsPostExistCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AddPostDetailsCompletedEventHandler(object sender, AddPostDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddPostDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddPostDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void UpdateFbPagePostStatusCompletedEventHandler(object sender, UpdateFbPagePostStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateFbPagePostStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateFbPagePostStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591