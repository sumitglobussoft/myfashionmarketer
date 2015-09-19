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

namespace Myfashionmarketer.Api.MailSender {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="MailSenderSoap", Namespace="http://tempuri.org/")]
    public partial class MailSender : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendAgencyMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendEnterpriseMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendCareerMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendRequestForDemoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendChangePasswordMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendFeedMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendAddNewsLatterMailOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendTaskNotificationMailOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MailSender() {
            this.Url = global::Myfashionmarketer.Properties.Settings.Default.Myfashionmarketer_Api_MailSender_MailSender;
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
        public event SendMailCompletedEventHandler SendMailCompleted;
        
        /// <remarks/>
        public event SendAgencyMailCompletedEventHandler SendAgencyMailCompleted;
        
        /// <remarks/>
        public event SendEnterpriseMailCompletedEventHandler SendEnterpriseMailCompleted;
        
        /// <remarks/>
        public event SendCareerMailCompletedEventHandler SendCareerMailCompleted;
        
        /// <remarks/>
        public event SendRequestForDemoCompletedEventHandler SendRequestForDemoCompleted;
        
        /// <remarks/>
        public event SendChangePasswordMailCompletedEventHandler SendChangePasswordMailCompleted;
        
        /// <remarks/>
        public event SendFeedMailCompletedEventHandler SendFeedMailCompleted;
        
        /// <remarks/>
        public event SendAddNewsLatterMailCompletedEventHandler SendAddNewsLatterMailCompleted;
        
        /// <remarks/>
        public event SendTaskNotificationMailCompletedEventHandler SendTaskNotificationMailCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendMail(string name, string lname, string email, string Subject, string profile) {
            object[] results = this.Invoke("SendMail", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        profile});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendMailAsync(string name, string lname, string email, string Subject, string profile) {
            this.SendMailAsync(name, lname, email, Subject, profile, null);
        }
        
        /// <remarks/>
        public void SendMailAsync(string name, string lname, string email, string Subject, string profile, object userState) {
            if ((this.SendMailOperationCompleted == null)) {
                this.SendMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMailOperationCompleted);
            }
            this.InvokeAsync("SendMail", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        profile}, this.SendMailOperationCompleted, userState);
        }
        
        private void OnSendMailOperationCompleted(object arg) {
            if ((this.SendMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMailCompleted(this, new SendMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendAgencyMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendAgencyMail(string name, string lname, string email, string Company, string message, string Phone) {
            object[] results = this.Invoke("SendAgencyMail", new object[] {
                        name,
                        lname,
                        email,
                        Company,
                        message,
                        Phone});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendAgencyMailAsync(string name, string lname, string email, string Company, string message, string Phone) {
            this.SendAgencyMailAsync(name, lname, email, Company, message, Phone, null);
        }
        
        /// <remarks/>
        public void SendAgencyMailAsync(string name, string lname, string email, string Company, string message, string Phone, object userState) {
            if ((this.SendAgencyMailOperationCompleted == null)) {
                this.SendAgencyMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAgencyMailOperationCompleted);
            }
            this.InvokeAsync("SendAgencyMail", new object[] {
                        name,
                        lname,
                        email,
                        Company,
                        message,
                        Phone}, this.SendAgencyMailOperationCompleted, userState);
        }
        
        private void OnSendAgencyMailOperationCompleted(object arg) {
            if ((this.SendAgencyMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAgencyMailCompleted(this, new SendAgencyMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendEnterpriseMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendEnterpriseMail(string name, string designation, string email, string location, string Company, string companywebsite, string message, string Phone) {
            object[] results = this.Invoke("SendEnterpriseMail", new object[] {
                        name,
                        designation,
                        email,
                        location,
                        Company,
                        companywebsite,
                        message,
                        Phone});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendEnterpriseMailAsync(string name, string designation, string email, string location, string Company, string companywebsite, string message, string Phone) {
            this.SendEnterpriseMailAsync(name, designation, email, location, Company, companywebsite, message, Phone, null);
        }
        
        /// <remarks/>
        public void SendEnterpriseMailAsync(string name, string designation, string email, string location, string Company, string companywebsite, string message, string Phone, object userState) {
            if ((this.SendEnterpriseMailOperationCompleted == null)) {
                this.SendEnterpriseMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendEnterpriseMailOperationCompleted);
            }
            this.InvokeAsync("SendEnterpriseMail", new object[] {
                        name,
                        designation,
                        email,
                        location,
                        Company,
                        companywebsite,
                        message,
                        Phone}, this.SendEnterpriseMailOperationCompleted, userState);
        }
        
        private void OnSendEnterpriseMailOperationCompleted(object arg) {
            if ((this.SendEnterpriseMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendEnterpriseMailCompleted(this, new SendEnterpriseMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendCareerMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendCareerMail(string name, string lname, string email, string Subject, string profile, string filepath, string filename, string filetype) {
            object[] results = this.Invoke("SendCareerMail", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        profile,
                        filepath,
                        filename,
                        filetype});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendCareerMailAsync(string name, string lname, string email, string Subject, string profile, string filepath, string filename, string filetype) {
            this.SendCareerMailAsync(name, lname, email, Subject, profile, filepath, filename, filetype, null);
        }
        
        /// <remarks/>
        public void SendCareerMailAsync(string name, string lname, string email, string Subject, string profile, string filepath, string filename, string filetype, object userState) {
            if ((this.SendCareerMailOperationCompleted == null)) {
                this.SendCareerMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendCareerMailOperationCompleted);
            }
            this.InvokeAsync("SendCareerMail", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        profile,
                        filepath,
                        filename,
                        filetype}, this.SendCareerMailOperationCompleted, userState);
        }
        
        private void OnSendCareerMailOperationCompleted(object arg) {
            if ((this.SendCareerMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendCareerMailCompleted(this, new SendCareerMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendRequestForDemo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendRequestForDemo(string name, string lname, string email, string Subject, string body) {
            object[] results = this.Invoke("SendRequestForDemo", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        body});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendRequestForDemoAsync(string name, string lname, string email, string Subject, string body) {
            this.SendRequestForDemoAsync(name, lname, email, Subject, body, null);
        }
        
        /// <remarks/>
        public void SendRequestForDemoAsync(string name, string lname, string email, string Subject, string body, object userState) {
            if ((this.SendRequestForDemoOperationCompleted == null)) {
                this.SendRequestForDemoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendRequestForDemoOperationCompleted);
            }
            this.InvokeAsync("SendRequestForDemo", new object[] {
                        name,
                        lname,
                        email,
                        Subject,
                        body}, this.SendRequestForDemoOperationCompleted, userState);
        }
        
        private void OnSendRequestForDemoOperationCompleted(object arg) {
            if ((this.SendRequestForDemoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendRequestForDemoCompleted(this, new SendRequestForDemoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendChangePasswordMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendChangePasswordMail(string emailId, string mailBody, string Subject) {
            object[] results = this.Invoke("SendChangePasswordMail", new object[] {
                        emailId,
                        mailBody,
                        Subject});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendChangePasswordMailAsync(string emailId, string mailBody, string Subject) {
            this.SendChangePasswordMailAsync(emailId, mailBody, Subject, null);
        }
        
        /// <remarks/>
        public void SendChangePasswordMailAsync(string emailId, string mailBody, string Subject, object userState) {
            if ((this.SendChangePasswordMailOperationCompleted == null)) {
                this.SendChangePasswordMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendChangePasswordMailOperationCompleted);
            }
            this.InvokeAsync("SendChangePasswordMail", new object[] {
                        emailId,
                        mailBody,
                        Subject}, this.SendChangePasswordMailOperationCompleted, userState);
        }
        
        private void OnSendChangePasswordMailOperationCompleted(object arg) {
            if ((this.SendChangePasswordMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendChangePasswordMailCompleted(this, new SendChangePasswordMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendFeedMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendFeedMail(string emailId, string feed, string fromname, string mailBody) {
            object[] results = this.Invoke("SendFeedMail", new object[] {
                        emailId,
                        feed,
                        fromname,
                        mailBody});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendFeedMailAsync(string emailId, string feed, string fromname, string mailBody) {
            this.SendFeedMailAsync(emailId, feed, fromname, mailBody, null);
        }
        
        /// <remarks/>
        public void SendFeedMailAsync(string emailId, string feed, string fromname, string mailBody, object userState) {
            if ((this.SendFeedMailOperationCompleted == null)) {
                this.SendFeedMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendFeedMailOperationCompleted);
            }
            this.InvokeAsync("SendFeedMail", new object[] {
                        emailId,
                        feed,
                        fromname,
                        mailBody}, this.SendFeedMailOperationCompleted, userState);
        }
        
        private void OnSendFeedMailOperationCompleted(object arg) {
            if ((this.SendFeedMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendFeedMailCompleted(this, new SendFeedMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendAddNewsLatterMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendAddNewsLatterMail(string emailId, string mailBody, string Subject) {
            object[] results = this.Invoke("SendAddNewsLatterMail", new object[] {
                        emailId,
                        mailBody,
                        Subject});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendAddNewsLatterMailAsync(string emailId, string mailBody, string Subject) {
            this.SendAddNewsLatterMailAsync(emailId, mailBody, Subject, null);
        }
        
        /// <remarks/>
        public void SendAddNewsLatterMailAsync(string emailId, string mailBody, string Subject, object userState) {
            if ((this.SendAddNewsLatterMailOperationCompleted == null)) {
                this.SendAddNewsLatterMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendAddNewsLatterMailOperationCompleted);
            }
            this.InvokeAsync("SendAddNewsLatterMail", new object[] {
                        emailId,
                        mailBody,
                        Subject}, this.SendAddNewsLatterMailOperationCompleted, userState);
        }
        
        private void OnSendAddNewsLatterMailOperationCompleted(object arg) {
            if ((this.SendAddNewsLatterMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendAddNewsLatterMailCompleted(this, new SendAddNewsLatterMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendTaskNotificationMail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendTaskNotificationMail(string emailId, string mailBody, string Subject) {
            object[] results = this.Invoke("SendTaskNotificationMail", new object[] {
                        emailId,
                        mailBody,
                        Subject});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendTaskNotificationMailAsync(string emailId, string mailBody, string Subject) {
            this.SendTaskNotificationMailAsync(emailId, mailBody, Subject, null);
        }
        
        /// <remarks/>
        public void SendTaskNotificationMailAsync(string emailId, string mailBody, string Subject, object userState) {
            if ((this.SendTaskNotificationMailOperationCompleted == null)) {
                this.SendTaskNotificationMailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendTaskNotificationMailOperationCompleted);
            }
            this.InvokeAsync("SendTaskNotificationMail", new object[] {
                        emailId,
                        mailBody,
                        Subject}, this.SendTaskNotificationMailOperationCompleted, userState);
        }
        
        private void OnSendTaskNotificationMailOperationCompleted(object arg) {
            if ((this.SendTaskNotificationMailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendTaskNotificationMailCompleted(this, new SendTaskNotificationMailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void SendMailCompletedEventHandler(object sender, SendMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendAgencyMailCompletedEventHandler(object sender, SendAgencyMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendAgencyMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendAgencyMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendEnterpriseMailCompletedEventHandler(object sender, SendEnterpriseMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendEnterpriseMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendEnterpriseMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendCareerMailCompletedEventHandler(object sender, SendCareerMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendCareerMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendCareerMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendRequestForDemoCompletedEventHandler(object sender, SendRequestForDemoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendRequestForDemoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendRequestForDemoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendChangePasswordMailCompletedEventHandler(object sender, SendChangePasswordMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendChangePasswordMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendChangePasswordMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendFeedMailCompletedEventHandler(object sender, SendFeedMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendFeedMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendFeedMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendAddNewsLatterMailCompletedEventHandler(object sender, SendAddNewsLatterMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendAddNewsLatterMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendAddNewsLatterMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SendTaskNotificationMailCompletedEventHandler(object sender, SendTaskNotificationMailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendTaskNotificationMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendTaskNotificationMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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