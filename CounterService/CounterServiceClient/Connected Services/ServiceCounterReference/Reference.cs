﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CounterServiceClient.ServiceCounterReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCounterReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCounter", ReplyAction="http://tempuri.org/IService1/GetCounterResponse")]
        int GetCounter(bool stateless);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCounter", ReplyAction="http://tempuri.org/IService1/GetCounterResponse")]
        System.Threading.Tasks.Task<int> GetCounterAsync(bool stateless);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CounterServiceClient.ServiceCounterReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CounterServiceClient.ServiceCounterReference.IService1>, CounterServiceClient.ServiceCounterReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetCounter(bool stateless) {
            return base.Channel.GetCounter(stateless);
        }
        
        public System.Threading.Tasks.Task<int> GetCounterAsync(bool stateless) {
            return base.Channel.GetCounterAsync(stateless);
        }
    }
}
