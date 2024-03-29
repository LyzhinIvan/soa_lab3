﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGlobalTimeService")]
public interface IGlobalTimeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/currentTime", ReplyAction="http://tempuri.org/IGlobalTimeService/currentTimeResponse")]
    string currentTime(string timeZone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/currentTime", ReplyAction="http://tempuri.org/IGlobalTimeService/currentTimeResponse")]
    System.Threading.Tasks.Task<string> currentTimeAsync(string timeZone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/timeInGuestZone", ReplyAction="http://tempuri.org/IGlobalTimeService/timeInGuestZoneResponse")]
    string timeInGuestZone(string time, string homeTimeZone, string guestTimeZone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/timeInGuestZone", ReplyAction="http://tempuri.org/IGlobalTimeService/timeInGuestZoneResponse")]
    System.Threading.Tasks.Task<string> timeInGuestZoneAsync(string time, string homeTimeZone, string guestTimeZone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/plusHours", ReplyAction="http://tempuri.org/IGlobalTimeService/plusHoursResponse")]
    string plusHours(string timeZone, int hoursCount);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/plusHours", ReplyAction="http://tempuri.org/IGlobalTimeService/plusHoursResponse")]
    System.Threading.Tasks.Task<string> plusHoursAsync(string timeZone, int hoursCount);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/timeBetween", ReplyAction="http://tempuri.org/IGlobalTimeService/timeBetweenResponse")]
    string timeBetween(string firstTimeZone, string secondTimeZone);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalTimeService/timeBetween", ReplyAction="http://tempuri.org/IGlobalTimeService/timeBetweenResponse")]
    System.Threading.Tasks.Task<string> timeBetweenAsync(string firstTimeZone, string secondTimeZone);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IGlobalTimeServiceChannel : IGlobalTimeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GlobalTimeServiceClient : System.ServiceModel.ClientBase<IGlobalTimeService>, IGlobalTimeService
{
    
    public GlobalTimeServiceClient()
    {
    }
    
    public GlobalTimeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GlobalTimeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GlobalTimeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GlobalTimeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string currentTime(string timeZone)
    {
        return base.Channel.currentTime(timeZone);
    }
    
    public System.Threading.Tasks.Task<string> currentTimeAsync(string timeZone)
    {
        return base.Channel.currentTimeAsync(timeZone);
    }
    
    public string timeInGuestZone(string time, string homeTimeZone, string guestTimeZone)
    {
        return base.Channel.timeInGuestZone(time, homeTimeZone, guestTimeZone);
    }
    
    public System.Threading.Tasks.Task<string> timeInGuestZoneAsync(string time, string homeTimeZone, string guestTimeZone)
    {
        return base.Channel.timeInGuestZoneAsync(time, homeTimeZone, guestTimeZone);
    }
    
    public string plusHours(string timeZone, int hoursCount)
    {
        return base.Channel.plusHours(timeZone, hoursCount);
    }
    
    public System.Threading.Tasks.Task<string> plusHoursAsync(string timeZone, int hoursCount)
    {
        return base.Channel.plusHoursAsync(timeZone, hoursCount);
    }
    
    public string timeBetween(string firstTimeZone, string secondTimeZone)
    {
        return base.Channel.timeBetween(firstTimeZone, secondTimeZone);
    }
    
    public System.Threading.Tasks.Task<string> timeBetweenAsync(string firstTimeZone, string secondTimeZone)
    {
        return base.Channel.timeBetweenAsync(firstTimeZone, secondTimeZone);
    }
}
