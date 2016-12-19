﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathServiceClient.MathServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.MathServiceSoap")]
    public interface MathServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        float Subtract(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<float> SubtractAsync(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        float Multiply(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<float> MultiplyAsync(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        float Divide(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<float> DivideAsync(float A, float B);
        
        // CODEGEN: Generating message contract since element name GetListOfStringsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListOfStrings", ReplyAction="*")]
        MathServiceClient.MathServiceReference.GetListOfStringsResponse GetListOfStrings(MathServiceClient.MathServiceReference.GetListOfStringsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetListOfStrings", ReplyAction="*")]
        System.Threading.Tasks.Task<MathServiceClient.MathServiceReference.GetListOfStringsResponse> GetListOfStringsAsync(MathServiceClient.MathServiceReference.GetListOfStringsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListOfStringsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListOfStrings", Namespace="http://tempuri.org/", Order=0)]
        public MathServiceClient.MathServiceReference.GetListOfStringsRequestBody Body;
        
        public GetListOfStringsRequest() {
        }
        
        public GetListOfStringsRequest(MathServiceClient.MathServiceReference.GetListOfStringsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetListOfStringsRequestBody {
        
        public GetListOfStringsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListOfStringsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListOfStringsResponse", Namespace="http://tempuri.org/", Order=0)]
        public MathServiceClient.MathServiceReference.GetListOfStringsResponseBody Body;
        
        public GetListOfStringsResponse() {
        }
        
        public GetListOfStringsResponse(MathServiceClient.MathServiceReference.GetListOfStringsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListOfStringsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MathServiceClient.MathServiceReference.ArrayOfString GetListOfStringsResult;
        
        public GetListOfStringsResponseBody() {
        }
        
        public GetListOfStringsResponseBody(MathServiceClient.MathServiceReference.ArrayOfString GetListOfStringsResult) {
            this.GetListOfStringsResult = GetListOfStringsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MathServiceSoapChannel : MathServiceClient.MathServiceReference.MathServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceSoapClient : System.ServiceModel.ClientBase<MathServiceClient.MathServiceReference.MathServiceSoap>, MathServiceClient.MathServiceReference.MathServiceSoap {
        
        public MathServiceSoapClient() {
        }
        
        public MathServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public float Subtract(float A, float B) {
            return base.Channel.Subtract(A, B);
        }
        
        public System.Threading.Tasks.Task<float> SubtractAsync(float A, float B) {
            return base.Channel.SubtractAsync(A, B);
        }
        
        public float Multiply(float A, float B) {
            return base.Channel.Multiply(A, B);
        }
        
        public System.Threading.Tasks.Task<float> MultiplyAsync(float A, float B) {
            return base.Channel.MultiplyAsync(A, B);
        }
        
        public float Divide(float A, float B) {
            return base.Channel.Divide(A, B);
        }
        
        public System.Threading.Tasks.Task<float> DivideAsync(float A, float B) {
            return base.Channel.DivideAsync(A, B);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MathServiceClient.MathServiceReference.GetListOfStringsResponse MathServiceClient.MathServiceReference.MathServiceSoap.GetListOfStrings(MathServiceClient.MathServiceReference.GetListOfStringsRequest request) {
            return base.Channel.GetListOfStrings(request);
        }
        
        public MathServiceClient.MathServiceReference.ArrayOfString GetListOfStrings() {
            MathServiceClient.MathServiceReference.GetListOfStringsRequest inValue = new MathServiceClient.MathServiceReference.GetListOfStringsRequest();
            inValue.Body = new MathServiceClient.MathServiceReference.GetListOfStringsRequestBody();
            MathServiceClient.MathServiceReference.GetListOfStringsResponse retVal = ((MathServiceClient.MathServiceReference.MathServiceSoap)(this)).GetListOfStrings(inValue);
            return retVal.Body.GetListOfStringsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MathServiceClient.MathServiceReference.GetListOfStringsResponse> MathServiceClient.MathServiceReference.MathServiceSoap.GetListOfStringsAsync(MathServiceClient.MathServiceReference.GetListOfStringsRequest request) {
            return base.Channel.GetListOfStringsAsync(request);
        }
        
        public System.Threading.Tasks.Task<MathServiceClient.MathServiceReference.GetListOfStringsResponse> GetListOfStringsAsync() {
            MathServiceClient.MathServiceReference.GetListOfStringsRequest inValue = new MathServiceClient.MathServiceReference.GetListOfStringsRequest();
            inValue.Body = new MathServiceClient.MathServiceReference.GetListOfStringsRequestBody();
            return ((MathServiceClient.MathServiceReference.MathServiceSoap)(this)).GetListOfStringsAsync(inValue);
        }
    }
}
