﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.18444.
// 
#pragma warning disable 1591

namespace WebWS.LlavesWS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetRegistrarLlavePublicaOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetValidarTextoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCifrarTextoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WebWS.Properties.Settings.Default.WebWS_LlavesWS_Service1;
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
        public event GetRegistrarLlavePublicaCompletedEventHandler GetRegistrarLlavePublicaCompleted;
        
        /// <remarks/>
        public event GetValidarTextoCompletedEventHandler GetValidarTextoCompleted;
        
        /// <remarks/>
        public event GetCifrarTextoCompletedEventHandler GetCifrarTextoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetRegistrarLlavePublica", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Respuesta GetRegistrarLlavePublica([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Registrar pub) {
            object[] results = this.Invoke("GetRegistrarLlavePublica", new object[] {
                        pub});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void GetRegistrarLlavePublicaAsync(Registrar pub) {
            this.GetRegistrarLlavePublicaAsync(pub, null);
        }
        
        /// <remarks/>
        public void GetRegistrarLlavePublicaAsync(Registrar pub, object userState) {
            if ((this.GetRegistrarLlavePublicaOperationCompleted == null)) {
                this.GetRegistrarLlavePublicaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRegistrarLlavePublicaOperationCompleted);
            }
            this.InvokeAsync("GetRegistrarLlavePublica", new object[] {
                        pub}, this.GetRegistrarLlavePublicaOperationCompleted, userState);
        }
        
        private void OnGetRegistrarLlavePublicaOperationCompleted(object arg) {
            if ((this.GetRegistrarLlavePublicaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRegistrarLlavePublicaCompleted(this, new GetRegistrarLlavePublicaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetValidarTexto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetValidarTexto([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Validar val, out HttpStatusCode GetValidarTextoResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool GetValidarTextoResultSpecified) {
            object[] results = this.Invoke("GetValidarTexto", new object[] {
                        val});
            GetValidarTextoResult = ((HttpStatusCode)(results[0]));
            GetValidarTextoResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void GetValidarTextoAsync(Validar val) {
            this.GetValidarTextoAsync(val, null);
        }
        
        /// <remarks/>
        public void GetValidarTextoAsync(Validar val, object userState) {
            if ((this.GetValidarTextoOperationCompleted == null)) {
                this.GetValidarTextoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetValidarTextoOperationCompleted);
            }
            this.InvokeAsync("GetValidarTexto", new object[] {
                        val}, this.GetValidarTextoOperationCompleted, userState);
        }
        
        private void OnGetValidarTextoOperationCompleted(object arg) {
            if ((this.GetValidarTextoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetValidarTextoCompleted(this, new GetValidarTextoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetCifrarTexto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Cifrado GetCifrarTexto([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Cifrar pub) {
            object[] results = this.Invoke("GetCifrarTexto", new object[] {
                        pub});
            return ((Cifrado)(results[0]));
        }
        
        /// <remarks/>
        public void GetCifrarTextoAsync(Cifrar pub) {
            this.GetCifrarTextoAsync(pub, null);
        }
        
        /// <remarks/>
        public void GetCifrarTextoAsync(Cifrar pub, object userState) {
            if ((this.GetCifrarTextoOperationCompleted == null)) {
                this.GetCifrarTextoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCifrarTextoOperationCompleted);
            }
            this.InvokeAsync("GetCifrarTexto", new object[] {
                        pub}, this.GetCifrarTextoOperationCompleted, userState);
        }
        
        private void OnGetCifrarTextoOperationCompleted(object arg) {
            if ((this.GetCifrarTextoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCifrarTextoCompleted(this, new GetCifrarTextoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class Registrar {
        
        private string pubField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string pub {
            get {
                return this.pubField;
            }
            set {
                this.pubField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class Cifrado {
        
        private string textoCifradoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string textoCifrado {
            get {
                return this.textoCifradoField;
            }
            set {
                this.textoCifradoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class Cifrar {
        
        private string idField;
        
        private string textoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string texto {
            get {
                return this.textoField;
            }
            set {
                this.textoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class Validar {
        
        private string clearTextField;
        
        private string cryptedTextField;
        
        private string idField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clearText {
            get {
                return this.clearTextField;
            }
            set {
                this.clearTextField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cryptedText {
            get {
                return this.cryptedTextField;
            }
            set {
                this.cryptedTextField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    public partial class Respuesta {
        
        private string idField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Net")]
    public enum HttpStatusCode {
        
        /// <comentarios/>
        Continue,
        
        /// <comentarios/>
        SwitchingProtocols,
        
        /// <comentarios/>
        OK,
        
        /// <comentarios/>
        Created,
        
        /// <comentarios/>
        Accepted,
        
        /// <comentarios/>
        NonAuthoritativeInformation,
        
        /// <comentarios/>
        NoContent,
        
        /// <comentarios/>
        ResetContent,
        
        /// <comentarios/>
        PartialContent,
        
        /// <comentarios/>
        MultipleChoices,
        
        /// <comentarios/>
        Ambiguous,
        
        /// <comentarios/>
        MovedPermanently,
        
        /// <comentarios/>
        Moved,
        
        /// <comentarios/>
        Found,
        
        /// <comentarios/>
        Redirect,
        
        /// <comentarios/>
        SeeOther,
        
        /// <comentarios/>
        RedirectMethod,
        
        /// <comentarios/>
        NotModified,
        
        /// <comentarios/>
        UseProxy,
        
        /// <comentarios/>
        Unused,
        
        /// <comentarios/>
        TemporaryRedirect,
        
        /// <comentarios/>
        RedirectKeepVerb,
        
        /// <comentarios/>
        BadRequest,
        
        /// <comentarios/>
        Unauthorized,
        
        /// <comentarios/>
        PaymentRequired,
        
        /// <comentarios/>
        Forbidden,
        
        /// <comentarios/>
        NotFound,
        
        /// <comentarios/>
        MethodNotAllowed,
        
        /// <comentarios/>
        NotAcceptable,
        
        /// <comentarios/>
        ProxyAuthenticationRequired,
        
        /// <comentarios/>
        RequestTimeout,
        
        /// <comentarios/>
        Conflict,
        
        /// <comentarios/>
        Gone,
        
        /// <comentarios/>
        LengthRequired,
        
        /// <comentarios/>
        PreconditionFailed,
        
        /// <comentarios/>
        RequestEntityTooLarge,
        
        /// <comentarios/>
        RequestUriTooLong,
        
        /// <comentarios/>
        UnsupportedMediaType,
        
        /// <comentarios/>
        RequestedRangeNotSatisfiable,
        
        /// <comentarios/>
        ExpectationFailed,
        
        /// <comentarios/>
        UpgradeRequired,
        
        /// <comentarios/>
        InternalServerError,
        
        /// <comentarios/>
        NotImplemented,
        
        /// <comentarios/>
        BadGateway,
        
        /// <comentarios/>
        ServiceUnavailable,
        
        /// <comentarios/>
        GatewayTimeout,
        
        /// <comentarios/>
        HttpVersionNotSupported,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetRegistrarLlavePublicaCompletedEventHandler(object sender, GetRegistrarLlavePublicaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRegistrarLlavePublicaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRegistrarLlavePublicaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Respuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Respuesta)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetValidarTextoCompletedEventHandler(object sender, GetValidarTextoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetValidarTextoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetValidarTextoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public HttpStatusCode GetValidarTextoResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((HttpStatusCode)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool GetValidarTextoResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetCifrarTextoCompletedEventHandler(object sender, GetCifrarTextoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCifrarTextoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCifrarTextoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Cifrado Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Cifrado)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591