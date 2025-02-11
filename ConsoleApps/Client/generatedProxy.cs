﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="myInterface")]
public interface myInterface
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myInterface/SecretNumber", ReplyAction="http://tempuri.org/myInterface/SecretNumberResponse")]
    int SecretNumber(int lower, int upper);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myInterface/SecretNumber", ReplyAction="http://tempuri.org/myInterface/SecretNumberResponse")]
    System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myInterface/checkNumber", ReplyAction="http://tempuri.org/myInterface/checkNumberResponse")]
    string checkNumber(int userNum, int SecretNum);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myInterface/checkNumber", ReplyAction="http://tempuri.org/myInterface/checkNumberResponse")]
    System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int SecretNum);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface myInterfaceChannel : myInterface, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class myInterfaceClient : System.ServiceModel.ClientBase<myInterface>, myInterface
{
    
    public myInterfaceClient()
    {
    }
    
    public myInterfaceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public myInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public myInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public myInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int SecretNumber(int lower, int upper)
    {
        return base.Channel.SecretNumber(lower, upper);
    }
    
    public System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper)
    {
        return base.Channel.SecretNumberAsync(lower, upper);
    }
    
    public string checkNumber(int userNum, int SecretNum)
    {
        return base.Channel.checkNumber(userNum, SecretNum);
    }
    
    public System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int SecretNum)
    {
        return base.Channel.checkNumberAsync(userNum, SecretNum);
    }
}
