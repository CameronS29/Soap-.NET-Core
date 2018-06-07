﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.SampleService {
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexModelInput", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ComplexModelInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringPropertyField;
        
        private int IntPropertyField;

		private List<string> ListPropertyField;

		[global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StringProperty {
            get {
                return this.StringPropertyField;
            }
            set {
                if ((object.ReferenceEquals(this.StringPropertyField, value) != true)) {
                    this.StringPropertyField = value;
                    this.RaisePropertyChanged("StringProperty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int IntProperty {
            get {
                return this.IntPropertyField;
            }
            set {
                if ((this.IntPropertyField.Equals(value) != true)) {
                    this.IntPropertyField = value;
                    this.RaisePropertyChanged("IntProperty");
                }
            }
        }

		[System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 2)]
		public List<string> ListProperty {
			get {
				return this.ListPropertyField;
			}
			set {
				if ((this.ListPropertyField.Equals(value) != true)) {
					this.ListPropertyField = value;
					this.RaisePropertyChanged("ListProperty");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexModelResponse", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ComplexModelResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private float FloatPropertyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringPropertyField;

		private List<string> ListPropertyField;

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
        public float FloatProperty {
            get {
                return this.FloatPropertyField;
            }
            set {
                if ((this.FloatPropertyField.Equals(value) != true)) {
                    this.FloatPropertyField = value;
                    this.RaisePropertyChanged("FloatProperty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StringProperty {
            get {
                return this.StringPropertyField;
            }
            set {
                if ((object.ReferenceEquals(this.StringPropertyField, value) != true)) {
                    this.StringPropertyField = value;
                    this.RaisePropertyChanged("StringProperty");
                }
            }
        }

		[System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
		public List<string> ListProperty {
			get {
				return this.ListPropertyField;
			}
			set {
				if ((this.ListPropertyField.Equals(value) != true)) {
					this.ListPropertyField = value;
					this.RaisePropertyChanged("ListProperty");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleService.ISampleService")]
    public interface ISampleService {
        
        // CODEGEN: Generating message contract since element name s from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/Ping", ReplyAction="*")]
        ConsoleApp1.SampleService.PingResponse Ping(ConsoleApp1.SampleService.PingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/Ping", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingResponse> PingAsync(ConsoleApp1.SampleService.PingRequest request);
        
        // CODEGEN: Generating message contract since element name inputModel from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PingComplexModel", ReplyAction="*")]
        ConsoleApp1.SampleService.PingComplexModelResponse PingComplexModel(ConsoleApp1.SampleService.PingComplexModelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PingComplexModel", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingComplexModelResponse> PingComplexModelAsync(ConsoleApp1.SampleService.PingComplexModelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/VoidMethod", ReplyAction="*")]
        void VoidMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/VoidMethod", ReplyAction="*")]
        System.Threading.Tasks.Task VoidMethodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AsyncMethod", ReplyAction="*")]
        int AsyncMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AsyncMethod", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AsyncMethodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/NullableMethod", ReplyAction="*")]
        System.Nullable<int> NullableMethod(System.Nullable<bool> arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/NullableMethod", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Nullable<int>> NullableMethodAsync(System.Nullable<bool> arg);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Ping", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.SampleService.PingRequestBody Body;
        
        public PingRequest() {
        }
        
        public PingRequest(ConsoleApp1.SampleService.PingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public PingRequestBody() {
        }
        
        public PingRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PingResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.SampleService.PingResponseBody Body;
        
        public PingResponse() {
        }
        
        public PingResponse(ConsoleApp1.SampleService.PingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PingResult;
        
        public PingResponseBody() {
        }
        
        public PingResponseBody(string PingResult) {
            this.PingResult = PingResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PingComplexModelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PingComplexModel", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.SampleService.PingComplexModelRequestBody Body;
        
        public PingComplexModelRequest() {
        }
        
        public PingComplexModelRequest(ConsoleApp1.SampleService.PingComplexModelRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PingComplexModelRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp1.SampleService.ComplexModelInput inputModel;
        
        public PingComplexModelRequestBody() {
        }
        
        public PingComplexModelRequestBody(ConsoleApp1.SampleService.ComplexModelInput inputModel) {
            this.inputModel = inputModel;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PingComplexModelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PingComplexModelResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.SampleService.PingComplexModelResponseBody Body;
        
        public PingComplexModelResponse() {
        }
        
        public PingComplexModelResponse(ConsoleApp1.SampleService.PingComplexModelResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PingComplexModelResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleApp1.SampleService.ComplexModelResponse PingComplexModelResult;
        
        public PingComplexModelResponseBody() {
        }
        
        public PingComplexModelResponseBody(ConsoleApp1.SampleService.ComplexModelResponse PingComplexModelResult) {
            this.PingComplexModelResult = PingComplexModelResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleServiceChannel : ConsoleApp1.SampleService.ISampleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<ConsoleApp1.SampleService.ISampleService>, ConsoleApp1.SampleService.ISampleService {
        
        public SampleServiceClient() {
        }
        
        public SampleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.SampleService.PingResponse ConsoleApp1.SampleService.ISampleService.Ping(ConsoleApp1.SampleService.PingRequest request) {
            return base.Channel.Ping(request);
        }
        
        public string Ping(string s) {
            ConsoleApp1.SampleService.PingRequest inValue = new ConsoleApp1.SampleService.PingRequest();
            inValue.Body = new ConsoleApp1.SampleService.PingRequestBody();
            inValue.Body.s = s;
            ConsoleApp1.SampleService.PingResponse retVal = ((ConsoleApp1.SampleService.ISampleService)(this)).Ping(inValue);
            return retVal.Body.PingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingResponse> ConsoleApp1.SampleService.ISampleService.PingAsync(ConsoleApp1.SampleService.PingRequest request) {
            return base.Channel.PingAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingResponse> PingAsync(string s) {
            ConsoleApp1.SampleService.PingRequest inValue = new ConsoleApp1.SampleService.PingRequest();
            inValue.Body = new ConsoleApp1.SampleService.PingRequestBody();
            inValue.Body.s = s;
            return ((ConsoleApp1.SampleService.ISampleService)(this)).PingAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.SampleService.PingComplexModelResponse ConsoleApp1.SampleService.ISampleService.PingComplexModel(ConsoleApp1.SampleService.PingComplexModelRequest request) {
            return base.Channel.PingComplexModel(request);
        }
        
        public ConsoleApp1.SampleService.ComplexModelResponse PingComplexModel(ConsoleApp1.SampleService.ComplexModelInput inputModel) {
            ConsoleApp1.SampleService.PingComplexModelRequest inValue = new ConsoleApp1.SampleService.PingComplexModelRequest();
            inValue.Body = new ConsoleApp1.SampleService.PingComplexModelRequestBody();
            inValue.Body.inputModel = inputModel;
            ConsoleApp1.SampleService.PingComplexModelResponse retVal = ((ConsoleApp1.SampleService.ISampleService)(this)).PingComplexModel(inValue);
            return retVal.Body.PingComplexModelResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingComplexModelResponse> ConsoleApp1.SampleService.ISampleService.PingComplexModelAsync(ConsoleApp1.SampleService.PingComplexModelRequest request) {
            return base.Channel.PingComplexModelAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.SampleService.PingComplexModelResponse> PingComplexModelAsync(ConsoleApp1.SampleService.ComplexModelInput inputModel) {
            ConsoleApp1.SampleService.PingComplexModelRequest inValue = new ConsoleApp1.SampleService.PingComplexModelRequest();
            inValue.Body = new ConsoleApp1.SampleService.PingComplexModelRequestBody();
            inValue.Body.inputModel = inputModel;
            return ((ConsoleApp1.SampleService.ISampleService)(this)).PingComplexModelAsync(inValue);
        }
        
        public void VoidMethod() {
            base.Channel.VoidMethod();
        }
        
        public System.Threading.Tasks.Task VoidMethodAsync() {
            return base.Channel.VoidMethodAsync();
        }
        
        public int AsyncMethod() {
            return base.Channel.AsyncMethod();
        }
        
        public System.Threading.Tasks.Task<int> AsyncMethodAsync() {
            return base.Channel.AsyncMethodAsync();
        }
        
        public System.Nullable<int> NullableMethod(System.Nullable<bool> arg) {
            return base.Channel.NullableMethod(arg);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> NullableMethodAsync(System.Nullable<bool> arg) {
            return base.Channel.NullableMethodAsync(arg);
        }
    }
}
