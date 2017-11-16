﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopClient.TempShiftService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumbOfHoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mail {
            get {
                return this.MailField;
            }
            set {
                if ((object.ReferenceEquals(this.MailField, value) != true)) {
                    this.MailField = value;
                    this.RaisePropertyChanged("Mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumbOfHours {
            get {
                return this.NumbOfHoursField;
            }
            set {
                if ((this.NumbOfHoursField.Equals(value) != true)) {
                    this.NumbOfHoursField = value;
                    this.RaisePropertyChanged("NumbOfHours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TempShift", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class TempShift : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopClient.TempShiftService.Employee ShiftEmployeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime WeekNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hours {
            get {
                return this.HoursField;
            }
            set {
                if ((this.HoursField.Equals(value) != true)) {
                    this.HoursField = value;
                    this.RaisePropertyChanged("Hours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopClient.TempShiftService.Employee ShiftEmployee {
            get {
                return this.ShiftEmployeeField;
            }
            set {
                if ((object.ReferenceEquals(this.ShiftEmployeeField, value) != true)) {
                    this.ShiftEmployeeField = value;
                    this.RaisePropertyChanged("ShiftEmployee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime WeekNumber {
            get {
                return this.WeekNumberField;
            }
            set {
                if ((this.WeekNumberField.Equals(value) != true)) {
                    this.WeekNumberField = value;
                    this.RaisePropertyChanged("WeekNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TempSchedule", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class TempSchedule : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfWeeksField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfWeeks {
            get {
                return this.NoOfWeeksField;
            }
            set {
                if ((this.NoOfWeeksField.Equals(value) != true)) {
                    this.NoOfWeeksField = value;
                    this.RaisePropertyChanged("NoOfWeeks");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TempShiftService.ITempShiftService")]
    public interface ITempShiftService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempShiftService/CreateTempShift", ReplyAction="http://tempuri.org/ITempShiftService/CreateTempShiftResponse")]
        DesktopClient.TempShiftService.TempShift CreateTempShift(System.DateTime weekNumber, int hours, System.DateTime startTime, DesktopClient.TempShiftService.Employee shiftEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempShiftService/CreateTempShift", ReplyAction="http://tempuri.org/ITempShiftService/CreateTempShiftResponse")]
        System.Threading.Tasks.Task<DesktopClient.TempShiftService.TempShift> CreateTempShiftAsync(System.DateTime weekNumber, int hours, System.DateTime startTime, DesktopClient.TempShiftService.Employee shiftEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempShiftService/FindTempShiftByID", ReplyAction="http://tempuri.org/ITempShiftService/FindTempShiftByIDResponse")]
        DesktopClient.TempShiftService.TempShift FindTempShiftByID(DesktopClient.TempShiftService.TempSchedule tSchedule, int tempShiftID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempShiftService/FindTempShiftByID", ReplyAction="http://tempuri.org/ITempShiftService/FindTempShiftByIDResponse")]
        System.Threading.Tasks.Task<DesktopClient.TempShiftService.TempShift> FindTempShiftByIDAsync(DesktopClient.TempShiftService.TempSchedule tSchedule, int tempShiftID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITempShiftServiceChannel : DesktopClient.TempShiftService.ITempShiftService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TempShiftServiceClient : System.ServiceModel.ClientBase<DesktopClient.TempShiftService.ITempShiftService>, DesktopClient.TempShiftService.ITempShiftService {
        
        public TempShiftServiceClient() {
        }
        
        public TempShiftServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TempShiftServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempShiftServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempShiftServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DesktopClient.TempShiftService.TempShift CreateTempShift(System.DateTime weekNumber, int hours, System.DateTime startTime, DesktopClient.TempShiftService.Employee shiftEmployee) {
            return base.Channel.CreateTempShift(weekNumber, hours, startTime, shiftEmployee);
        }
        
        public System.Threading.Tasks.Task<DesktopClient.TempShiftService.TempShift> CreateTempShiftAsync(System.DateTime weekNumber, int hours, System.DateTime startTime, DesktopClient.TempShiftService.Employee shiftEmployee) {
            return base.Channel.CreateTempShiftAsync(weekNumber, hours, startTime, shiftEmployee);
        }
        
        public DesktopClient.TempShiftService.TempShift FindTempShiftByID(DesktopClient.TempShiftService.TempSchedule tSchedule, int tempShiftID) {
            return base.Channel.FindTempShiftByID(tSchedule, tempShiftID);
        }
        
        public System.Threading.Tasks.Task<DesktopClient.TempShiftService.TempShift> FindTempShiftByIDAsync(DesktopClient.TempShiftService.TempSchedule tSchedule, int tempShiftID) {
            return base.Channel.FindTempShiftByIDAsync(tSchedule, tempShiftID);
        }
    }
}
