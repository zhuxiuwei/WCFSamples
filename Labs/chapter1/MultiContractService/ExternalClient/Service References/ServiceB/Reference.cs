﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExternalClient.ServiceB {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="ServiceB.IAdmin")]
    public interface IAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation1", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation1Response")]
        string AdminOperation1();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation1", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation1Response")]
        System.Threading.Tasks.Task<string> AdminOperation1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation2", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation2Response")]
        string AdminOperation2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation2", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IAdmin/AdminOperation2Response")]
        System.Threading.Tasks.Task<string> AdminOperation2Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminChannel : ExternalClient.ServiceB.IAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminClient : System.ServiceModel.ClientBase<ExternalClient.ServiceB.IAdmin>, ExternalClient.ServiceB.IAdmin {
        
        public AdminClient() {
        }
        
        public AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AdminOperation1() {
            return base.Channel.AdminOperation1();
        }
        
        public System.Threading.Tasks.Task<string> AdminOperation1Async() {
            return base.Channel.AdminOperation1Async();
        }
        
        public string AdminOperation2() {
            return base.Channel.AdminOperation2();
        }
        
        public System.Threading.Tasks.Task<string> AdminOperation2Async() {
            return base.Channel.AdminOperation2Async();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="ServiceB.IServiceB")]
    public interface IServiceB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IServiceB/Operation3", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IServiceB/Operation3Response")]
        string Operation3();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/IServiceB/Operation3", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/IServiceB/Operation3Response")]
        System.Threading.Tasks.Task<string> Operation3Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBChannel : ExternalClient.ServiceB.IServiceB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBClient : System.ServiceModel.ClientBase<ExternalClient.ServiceB.IServiceB>, ExternalClient.ServiceB.IServiceB {
        
        public ServiceBClient() {
        }
        
        public ServiceBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Operation3() {
            return base.Channel.Operation3();
        }
        
        public System.Threading.Tasks.Task<string> Operation3Async() {
            return base.Channel.Operation3Async();
        }
    }
}
