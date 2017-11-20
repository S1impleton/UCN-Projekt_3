﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.TempScheduleService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DayOfWeek", Namespace="http://schemas.datacontract.org/2004/07/System")]
    public enum DayOfWeek : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sunday = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Monday = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Tuesday = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Wednesday = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Thursday = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Friday = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Saturday = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TempScheduleService.ITempScheduleService")]
    public interface ITempScheduleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/GetAllTempSchedules", ReplyAction="http://tempuri.org/ITempScheduleService/GetAllTempSchedulesResponse")]
        Core.TemplateSchedule[] GetAllTempSchedules();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/GetAllTempSchedules", ReplyAction="http://tempuri.org/ITempScheduleService/GetAllTempSchedulesResponse")]
        System.Threading.Tasks.Task<Core.TemplateSchedule[]> GetAllTempSchedulesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/FindTempScheduleByName", ReplyAction="http://tempuri.org/ITempScheduleService/FindTempScheduleByNameResponse")]
        Core.TemplateSchedule FindTempScheduleByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/FindTempScheduleByName", ReplyAction="http://tempuri.org/ITempScheduleService/FindTempScheduleByNameResponse")]
        System.Threading.Tasks.Task<Core.TemplateSchedule> FindTempScheduleByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/AddTempScheduleToDB", ReplyAction="http://tempuri.org/ITempScheduleService/AddTempScheduleToDBResponse")]
        void AddTempScheduleToDB(Core.TemplateSchedule tSchedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/AddTempScheduleToDB", ReplyAction="http://tempuri.org/ITempScheduleService/AddTempScheduleToDBResponse")]
        System.Threading.Tasks.Task AddTempScheduleToDBAsync(Core.TemplateSchedule tSchedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/AddTempShift", ReplyAction="http://tempuri.org/ITempScheduleService/AddTempShiftResponse")]
        void AddTempShift(Core.TemplateShift tShift);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempScheduleService/AddTempShift", ReplyAction="http://tempuri.org/ITempScheduleService/AddTempShiftResponse")]
        System.Threading.Tasks.Task AddTempShiftAsync(Core.TemplateShift tShift);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITempScheduleServiceChannel : Tests.TempScheduleService.ITempScheduleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TempScheduleServiceClient : System.ServiceModel.ClientBase<Tests.TempScheduleService.ITempScheduleService>, Tests.TempScheduleService.ITempScheduleService {
        
        public TempScheduleServiceClient() {
        }
        
        public TempScheduleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TempScheduleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempScheduleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempScheduleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Core.TemplateSchedule[] GetAllTempSchedules() {
            return base.Channel.GetAllTempSchedules();
        }
        
        public System.Threading.Tasks.Task<Core.TemplateSchedule[]> GetAllTempSchedulesAsync() {
            return base.Channel.GetAllTempSchedulesAsync();
        }
        
        public Core.TemplateSchedule FindTempScheduleByName(string name) {
            return base.Channel.FindTempScheduleByName(name);
        }
        
        public System.Threading.Tasks.Task<Core.TemplateSchedule> FindTempScheduleByNameAsync(string name) {
            return base.Channel.FindTempScheduleByNameAsync(name);
        }
        
        public void AddTempScheduleToDB(Core.TemplateSchedule tSchedule) {
            base.Channel.AddTempScheduleToDB(tSchedule);
        }
        
        public System.Threading.Tasks.Task AddTempScheduleToDBAsync(Core.TemplateSchedule tSchedule) {
            return base.Channel.AddTempScheduleToDBAsync(tSchedule);
        }
        
        public void AddTempShift(Core.TemplateShift tShift) {
            base.Channel.AddTempShift(tShift);
        }
        
        public System.Threading.Tasks.Task AddTempShiftAsync(Core.TemplateShift tShift) {
            return base.Channel.AddTempShiftAsync(tShift);
        }
    }
}
