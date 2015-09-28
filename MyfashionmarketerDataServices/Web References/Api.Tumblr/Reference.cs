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

namespace SocioboardDataServices.Api.Tumblr {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TumblrSoap", Namespace="http://tempuri.org/")]
    public partial class Tumblr : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTumblrRedirectUrlOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddTumblrAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTumblrDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback SheduleTumblrMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback TumblerDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback TumblrComposeMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateTumblrAccountByAdminOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Tumblr() {
            this.Url = global::SocioboardDataServices.Properties.Settings.Default.SocioboardDataServices_Api_Tumblr_Tumblr;
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
        public event GetTumblrRedirectUrlCompletedEventHandler GetTumblrRedirectUrlCompleted;
        
        /// <remarks/>
        public event AddTumblrAccountCompletedEventHandler AddTumblrAccountCompleted;
        
        /// <remarks/>
        public event getTumblrDataCompletedEventHandler getTumblrDataCompleted;
        
        /// <remarks/>
        public event SheduleTumblrMessageCompletedEventHandler SheduleTumblrMessageCompleted;
        
        /// <remarks/>
        public event TumblerDataCompletedEventHandler TumblerDataCompleted;
        
        /// <remarks/>
        public event TumblrComposeMessageCompletedEventHandler TumblrComposeMessageCompleted;
        
        /// <remarks/>
        public event UpdateTumblrAccountByAdminCompletedEventHandler UpdateTumblrAccountByAdminCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTumblrRedirectUrl", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTumblrRedirectUrl(string consumerKey, string consumerSecret, string CallBackUrl) {
            object[] results = this.Invoke("GetTumblrRedirectUrl", new object[] {
                        consumerKey,
                        consumerSecret,
                        CallBackUrl});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTumblrRedirectUrlAsync(string consumerKey, string consumerSecret, string CallBackUrl) {
            this.GetTumblrRedirectUrlAsync(consumerKey, consumerSecret, CallBackUrl, null);
        }
        
        /// <remarks/>
        public void GetTumblrRedirectUrlAsync(string consumerKey, string consumerSecret, string CallBackUrl, object userState) {
            if ((this.GetTumblrRedirectUrlOperationCompleted == null)) {
                this.GetTumblrRedirectUrlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTumblrRedirectUrlOperationCompleted);
            }
            this.InvokeAsync("GetTumblrRedirectUrl", new object[] {
                        consumerKey,
                        consumerSecret,
                        CallBackUrl}, this.GetTumblrRedirectUrlOperationCompleted, userState);
        }
        
        private void OnGetTumblrRedirectUrlOperationCompleted(object arg) {
            if ((this.GetTumblrRedirectUrlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTumblrRedirectUrlCompleted(this, new GetTumblrRedirectUrlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTumblrAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddTumblrAccount(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            object[] results = this.Invoke("AddTumblrAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddTumblrAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            this.AddTumblrAccountAsync(client_id, client_secret, redirect_uri, UserId, GroupId, code, null);
        }
        
        /// <remarks/>
        public void AddTumblrAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code, object userState) {
            if ((this.AddTumblrAccountOperationCompleted == null)) {
                this.AddTumblrAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTumblrAccountOperationCompleted);
            }
            this.InvokeAsync("AddTumblrAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code}, this.AddTumblrAccountOperationCompleted, userState);
        }
        
        private void OnAddTumblrAccountOperationCompleted(object arg) {
            if ((this.AddTumblrAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTumblrAccountCompleted(this, new AddTumblrAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getTumblrData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getTumblrData(string UserId, string Tumblrid) {
            object[] results = this.Invoke("getTumblrData", new object[] {
                        UserId,
                        Tumblrid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTumblrDataAsync(string UserId, string Tumblrid) {
            this.getTumblrDataAsync(UserId, Tumblrid, null);
        }
        
        /// <remarks/>
        public void getTumblrDataAsync(string UserId, string Tumblrid, object userState) {
            if ((this.getTumblrDataOperationCompleted == null)) {
                this.getTumblrDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTumblrDataOperationCompleted);
            }
            this.InvokeAsync("getTumblrData", new object[] {
                        UserId,
                        Tumblrid}, this.getTumblrDataOperationCompleted, userState);
        }
        
        private void OngetTumblrDataOperationCompleted(object arg) {
            if ((this.getTumblrDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTumblrDataCompleted(this, new getTumblrDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SheduleTumblrMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SheduleTumblrMessage(string TumblrId, string UserId, string sscheduledmsgguid) {
            object[] results = this.Invoke("SheduleTumblrMessage", new object[] {
                        TumblrId,
                        UserId,
                        sscheduledmsgguid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SheduleTumblrMessageAsync(string TumblrId, string UserId, string sscheduledmsgguid) {
            this.SheduleTumblrMessageAsync(TumblrId, UserId, sscheduledmsgguid, null);
        }
        
        /// <remarks/>
        public void SheduleTumblrMessageAsync(string TumblrId, string UserId, string sscheduledmsgguid, object userState) {
            if ((this.SheduleTumblrMessageOperationCompleted == null)) {
                this.SheduleTumblrMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSheduleTumblrMessageOperationCompleted);
            }
            this.InvokeAsync("SheduleTumblrMessage", new object[] {
                        TumblrId,
                        UserId,
                        sscheduledmsgguid}, this.SheduleTumblrMessageOperationCompleted, userState);
        }
        
        private void OnSheduleTumblrMessageOperationCompleted(object arg) {
            if ((this.SheduleTumblrMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SheduleTumblrMessageCompleted(this, new SheduleTumblrMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TumblerData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TumblerData(string tumblrusername) {
            object[] results = this.Invoke("TumblerData", new object[] {
                        tumblrusername});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TumblerDataAsync(string tumblrusername) {
            this.TumblerDataAsync(tumblrusername, null);
        }
        
        /// <remarks/>
        public void TumblerDataAsync(string tumblrusername, object userState) {
            if ((this.TumblerDataOperationCompleted == null)) {
                this.TumblerDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTumblerDataOperationCompleted);
            }
            this.InvokeAsync("TumblerData", new object[] {
                        tumblrusername}, this.TumblerDataOperationCompleted, userState);
        }
        
        private void OnTumblerDataOperationCompleted(object arg) {
            if ((this.TumblerDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TumblerDataCompleted(this, new TumblerDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TumblrComposeMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TumblrComposeMessage(string message, string profileid, string userid, string currentdatetime, string picurl) {
            object[] results = this.Invoke("TumblrComposeMessage", new object[] {
                        message,
                        profileid,
                        userid,
                        currentdatetime,
                        picurl});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TumblrComposeMessageAsync(string message, string profileid, string userid, string currentdatetime, string picurl) {
            this.TumblrComposeMessageAsync(message, profileid, userid, currentdatetime, picurl, null);
        }
        
        /// <remarks/>
        public void TumblrComposeMessageAsync(string message, string profileid, string userid, string currentdatetime, string picurl, object userState) {
            if ((this.TumblrComposeMessageOperationCompleted == null)) {
                this.TumblrComposeMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTumblrComposeMessageOperationCompleted);
            }
            this.InvokeAsync("TumblrComposeMessage", new object[] {
                        message,
                        profileid,
                        userid,
                        currentdatetime,
                        picurl}, this.TumblrComposeMessageOperationCompleted, userState);
        }
        
        private void OnTumblrComposeMessageOperationCompleted(object arg) {
            if ((this.TumblrComposeMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TumblrComposeMessageCompleted(this, new TumblrComposeMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateTumblrAccountByAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateTumblrAccountByAdmin(string ObjTumblr) {
            object[] results = this.Invoke("UpdateTumblrAccountByAdmin", new object[] {
                        ObjTumblr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateTumblrAccountByAdminAsync(string ObjTumblr) {
            this.UpdateTumblrAccountByAdminAsync(ObjTumblr, null);
        }
        
        /// <remarks/>
        public void UpdateTumblrAccountByAdminAsync(string ObjTumblr, object userState) {
            if ((this.UpdateTumblrAccountByAdminOperationCompleted == null)) {
                this.UpdateTumblrAccountByAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTumblrAccountByAdminOperationCompleted);
            }
            this.InvokeAsync("UpdateTumblrAccountByAdmin", new object[] {
                        ObjTumblr}, this.UpdateTumblrAccountByAdminOperationCompleted, userState);
        }
        
        private void OnUpdateTumblrAccountByAdminOperationCompleted(object arg) {
            if ((this.UpdateTumblrAccountByAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTumblrAccountByAdminCompleted(this, new UpdateTumblrAccountByAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetTumblrRedirectUrlCompletedEventHandler(object sender, GetTumblrRedirectUrlCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTumblrRedirectUrlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTumblrRedirectUrlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void AddTumblrAccountCompletedEventHandler(object sender, AddTumblrAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTumblrAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTumblrAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getTumblrDataCompletedEventHandler(object sender, getTumblrDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTumblrDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTumblrDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SheduleTumblrMessageCompletedEventHandler(object sender, SheduleTumblrMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SheduleTumblrMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SheduleTumblrMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void TumblerDataCompletedEventHandler(object sender, TumblerDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TumblerDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TumblerDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void TumblrComposeMessageCompletedEventHandler(object sender, TumblrComposeMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TumblrComposeMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TumblrComposeMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateTumblrAccountByAdminCompletedEventHandler(object sender, UpdateTumblrAccountByAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateTumblrAccountByAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateTumblrAccountByAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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