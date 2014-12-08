﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Socioboard.Api.FbPagePost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FbPagePostSoap", Namespace="http://tempuri.org/")]
    public partial class FbPagePost : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPostDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllPostOfPageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FbPagePost() {
            this.Url = "http://localhost:6361/Services/FbPagePost.asmx";
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetPostDetailsCompletedEventHandler(object sender, GetPostDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllPostOfPageCompletedEventHandler(object sender, GetAllPostOfPageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
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
}

#pragma warning restore 1591