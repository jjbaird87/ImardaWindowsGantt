﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace I360_POC.Login {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseOfDateTime", Namespace="http://i360api.imardainc.com/")]
    [System.SerializableAttribute()]
    public partial class ResponseOfDateTime : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private I360_POC.Login.ResponseCode CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        private System.DateTime ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public I360_POC.Login.ResponseCode Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseCode", Namespace="http://i360api.imardainc.com/")]
    public enum ResponseCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fail = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OK = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unauthorized = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Invalid = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Duplicate = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Obsolete = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoAccess = 6,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseOfi360Session", Namespace="http://i360api.imardainc.com/")]
    [System.SerializableAttribute()]
    public partial class ResponseOfi360Session : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private I360_POC.Login.ResponseCode CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private I360_POC.Login.i360Session ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public I360_POC.Login.ResponseCode Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public I360_POC.Login.i360Session Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="i360Session", Namespace="http://i360api.imardainc.com/")]
    [System.SerializableAttribute()]
    public partial class i360Session : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid SessionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceUriField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Guid SessionID {
            get {
                return this.SessionIDField;
            }
            set {
                if ((this.SessionIDField.Equals(value) != true)) {
                    this.SessionIDField = value;
                    this.RaisePropertyChanged("SessionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ServiceUri {
            get {
                return this.ServiceUriField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceUriField, value) != true)) {
                    this.ServiceUriField = value;
                    this.RaisePropertyChanged("ServiceUri");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseOfString", Namespace="http://i360api.imardainc.com/")]
    [System.SerializableAttribute()]
    public partial class ResponseOfString : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private I360_POC.Login.ResponseCode CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public I360_POC.Login.ResponseCode Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://i360api.imardainc.com/", ConfigurationName="Login.ConnectAPISoap")]
    public interface ConnectAPISoap {
        
        // CODEGEN: Generating message contract since element name CurrentServerTimeResult from namespace http://i360api.imardainc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/CurrentServerTime", ReplyAction="*")]
        I360_POC.Login.CurrentServerTimeResponse CurrentServerTime(I360_POC.Login.CurrentServerTimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/CurrentServerTime", ReplyAction="*")]
        System.Threading.Tasks.Task<I360_POC.Login.CurrentServerTimeResponse> CurrentServerTimeAsync(I360_POC.Login.CurrentServerTimeRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://i360api.imardainc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/Login", ReplyAction="*")]
        I360_POC.Login.LoginResponse Login(I360_POC.Login.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<I360_POC.Login.LoginResponse> LoginAsync(I360_POC.Login.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name GetVersionResult from namespace http://i360api.imardainc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/GetVersion", ReplyAction="*")]
        I360_POC.Login.GetVersionResponse GetVersion(I360_POC.Login.GetVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/GetVersion", ReplyAction="*")]
        System.Threading.Tasks.Task<I360_POC.Login.GetVersionResponse> GetVersionAsync(I360_POC.Login.GetVersionRequest request);
        
        // CODEGEN: Generating message contract since element name GetCodeVersionResult from namespace http://i360api.imardainc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/GetCodeVersion", ReplyAction="*")]
        I360_POC.Login.GetCodeVersionResponse GetCodeVersion(I360_POC.Login.GetCodeVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://i360api.imardainc.com/GetCodeVersion", ReplyAction="*")]
        System.Threading.Tasks.Task<I360_POC.Login.GetCodeVersionResponse> GetCodeVersionAsync(I360_POC.Login.GetCodeVersionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentServerTimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentServerTime", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.CurrentServerTimeRequestBody Body;
        
        public CurrentServerTimeRequest() {
        }
        
        public CurrentServerTimeRequest(I360_POC.Login.CurrentServerTimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CurrentServerTimeRequestBody {
        
        public CurrentServerTimeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentServerTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentServerTimeResponse", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.CurrentServerTimeResponseBody Body;
        
        public CurrentServerTimeResponse() {
        }
        
        public CurrentServerTimeResponse(I360_POC.Login.CurrentServerTimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://i360api.imardainc.com/")]
    public partial class CurrentServerTimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public I360_POC.Login.ResponseOfDateTime CurrentServerTimeResult;
        
        public CurrentServerTimeResponseBody() {
        }
        
        public CurrentServerTimeResponseBody(I360_POC.Login.ResponseOfDateTime CurrentServerTimeResult) {
            this.CurrentServerTimeResult = CurrentServerTimeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(I360_POC.Login.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://i360api.imardainc.com/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(I360_POC.Login.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://i360api.imardainc.com/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public I360_POC.Login.ResponseOfi360Session LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(I360_POC.Login.ResponseOfi360Session LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVersion", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.GetVersionRequestBody Body;
        
        public GetVersionRequest() {
        }
        
        public GetVersionRequest(I360_POC.Login.GetVersionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetVersionRequestBody {
        
        public GetVersionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVersionResponse", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.GetVersionResponseBody Body;
        
        public GetVersionResponse() {
        }
        
        public GetVersionResponse(I360_POC.Login.GetVersionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://i360api.imardainc.com/")]
    public partial class GetVersionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public I360_POC.Login.ResponseOfString GetVersionResult;
        
        public GetVersionResponseBody() {
        }
        
        public GetVersionResponseBody(I360_POC.Login.ResponseOfString GetVersionResult) {
            this.GetVersionResult = GetVersionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCodeVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCodeVersion", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.GetCodeVersionRequestBody Body;
        
        public GetCodeVersionRequest() {
        }
        
        public GetCodeVersionRequest(I360_POC.Login.GetCodeVersionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCodeVersionRequestBody {
        
        public GetCodeVersionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCodeVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCodeVersionResponse", Namespace="http://i360api.imardainc.com/", Order=0)]
        public I360_POC.Login.GetCodeVersionResponseBody Body;
        
        public GetCodeVersionResponse() {
        }
        
        public GetCodeVersionResponse(I360_POC.Login.GetCodeVersionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://i360api.imardainc.com/")]
    public partial class GetCodeVersionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public I360_POC.Login.ResponseOfString GetCodeVersionResult;
        
        public GetCodeVersionResponseBody() {
        }
        
        public GetCodeVersionResponseBody(I360_POC.Login.ResponseOfString GetCodeVersionResult) {
            this.GetCodeVersionResult = GetCodeVersionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConnectAPISoapChannel : I360_POC.Login.ConnectAPISoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConnectAPISoapClient : System.ServiceModel.ClientBase<I360_POC.Login.ConnectAPISoap>, I360_POC.Login.ConnectAPISoap {
        
        public ConnectAPISoapClient() {
        }
        
        public ConnectAPISoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConnectAPISoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectAPISoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectAPISoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        I360_POC.Login.CurrentServerTimeResponse I360_POC.Login.ConnectAPISoap.CurrentServerTime(I360_POC.Login.CurrentServerTimeRequest request) {
            return base.Channel.CurrentServerTime(request);
        }
        
        public I360_POC.Login.ResponseOfDateTime CurrentServerTime() {
            I360_POC.Login.CurrentServerTimeRequest inValue = new I360_POC.Login.CurrentServerTimeRequest();
            inValue.Body = new I360_POC.Login.CurrentServerTimeRequestBody();
            I360_POC.Login.CurrentServerTimeResponse retVal = ((I360_POC.Login.ConnectAPISoap)(this)).CurrentServerTime(inValue);
            return retVal.Body.CurrentServerTimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<I360_POC.Login.CurrentServerTimeResponse> I360_POC.Login.ConnectAPISoap.CurrentServerTimeAsync(I360_POC.Login.CurrentServerTimeRequest request) {
            return base.Channel.CurrentServerTimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<I360_POC.Login.CurrentServerTimeResponse> CurrentServerTimeAsync() {
            I360_POC.Login.CurrentServerTimeRequest inValue = new I360_POC.Login.CurrentServerTimeRequest();
            inValue.Body = new I360_POC.Login.CurrentServerTimeRequestBody();
            return ((I360_POC.Login.ConnectAPISoap)(this)).CurrentServerTimeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        I360_POC.Login.LoginResponse I360_POC.Login.ConnectAPISoap.Login(I360_POC.Login.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public I360_POC.Login.ResponseOfi360Session Login(string username, string password) {
            I360_POC.Login.LoginRequest inValue = new I360_POC.Login.LoginRequest();
            inValue.Body = new I360_POC.Login.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            I360_POC.Login.LoginResponse retVal = ((I360_POC.Login.ConnectAPISoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<I360_POC.Login.LoginResponse> I360_POC.Login.ConnectAPISoap.LoginAsync(I360_POC.Login.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<I360_POC.Login.LoginResponse> LoginAsync(string username, string password) {
            I360_POC.Login.LoginRequest inValue = new I360_POC.Login.LoginRequest();
            inValue.Body = new I360_POC.Login.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((I360_POC.Login.ConnectAPISoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        I360_POC.Login.GetVersionResponse I360_POC.Login.ConnectAPISoap.GetVersion(I360_POC.Login.GetVersionRequest request) {
            return base.Channel.GetVersion(request);
        }
        
        public I360_POC.Login.ResponseOfString GetVersion() {
            I360_POC.Login.GetVersionRequest inValue = new I360_POC.Login.GetVersionRequest();
            inValue.Body = new I360_POC.Login.GetVersionRequestBody();
            I360_POC.Login.GetVersionResponse retVal = ((I360_POC.Login.ConnectAPISoap)(this)).GetVersion(inValue);
            return retVal.Body.GetVersionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<I360_POC.Login.GetVersionResponse> I360_POC.Login.ConnectAPISoap.GetVersionAsync(I360_POC.Login.GetVersionRequest request) {
            return base.Channel.GetVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<I360_POC.Login.GetVersionResponse> GetVersionAsync() {
            I360_POC.Login.GetVersionRequest inValue = new I360_POC.Login.GetVersionRequest();
            inValue.Body = new I360_POC.Login.GetVersionRequestBody();
            return ((I360_POC.Login.ConnectAPISoap)(this)).GetVersionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        I360_POC.Login.GetCodeVersionResponse I360_POC.Login.ConnectAPISoap.GetCodeVersion(I360_POC.Login.GetCodeVersionRequest request) {
            return base.Channel.GetCodeVersion(request);
        }
        
        public I360_POC.Login.ResponseOfString GetCodeVersion() {
            I360_POC.Login.GetCodeVersionRequest inValue = new I360_POC.Login.GetCodeVersionRequest();
            inValue.Body = new I360_POC.Login.GetCodeVersionRequestBody();
            I360_POC.Login.GetCodeVersionResponse retVal = ((I360_POC.Login.ConnectAPISoap)(this)).GetCodeVersion(inValue);
            return retVal.Body.GetCodeVersionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<I360_POC.Login.GetCodeVersionResponse> I360_POC.Login.ConnectAPISoap.GetCodeVersionAsync(I360_POC.Login.GetCodeVersionRequest request) {
            return base.Channel.GetCodeVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<I360_POC.Login.GetCodeVersionResponse> GetCodeVersionAsync() {
            I360_POC.Login.GetCodeVersionRequest inValue = new I360_POC.Login.GetCodeVersionRequest();
            inValue.Body = new I360_POC.Login.GetCodeVersionRequestBody();
            return ((I360_POC.Login.ConnectAPISoap)(this)).GetCodeVersionAsync(inValue);
        }
    }
}
