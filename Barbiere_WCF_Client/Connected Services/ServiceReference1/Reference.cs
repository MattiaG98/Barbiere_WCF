﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barbiere_WCF_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registration", ReplyAction="http://tempuri.org/IService1/RegistrationResponse")]
        string Registration(string Nome, string Cognome, string Utente, string Password, bool Admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registration", ReplyAction="http://tempuri.org/IService1/RegistrationResponse")]
        System.Threading.Tasks.Task<string> RegistrationAsync(string Nome, string Cognome, string Utente, string Password, bool Admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserChecker", ReplyAction="http://tempuri.org/IService1/UserCheckerResponse")]
        bool UserChecker(string Utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserChecker", ReplyAction="http://tempuri.org/IService1/UserCheckerResponse")]
        System.Threading.Tasks.Task<bool> UserCheckerAsync(string Utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        bool Login(string Utente, string Password, bool Admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string Utente, string Password, bool Admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBooking", ReplyAction="http://tempuri.org/IService1/AddBookingResponse")]
        string AddBooking(string Utente, System.DateTime Date, System.DateTime Time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBooking", ReplyAction="http://tempuri.org/IService1/AddBookingResponse")]
        System.Threading.Tasks.Task<string> AddBookingAsync(string Utente, System.DateTime Date, System.DateTime Time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserPasswordChange", ReplyAction="http://tempuri.org/IService1/UserPasswordChangeResponse")]
        string UserPasswordChange(string Utente, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserPasswordChange", ReplyAction="http://tempuri.org/IService1/UserPasswordChangeResponse")]
        System.Threading.Tasks.Task<string> UserPasswordChangeAsync(string Utente, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Barbiere_WCF_Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Barbiere_WCF_Client.ServiceReference1.IService1>, Barbiere_WCF_Client.ServiceReference1.IService1 {
        
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
        
        public string Registration(string Nome, string Cognome, string Utente, string Password, bool Admin) {
            return base.Channel.Registration(Nome, Cognome, Utente, Password, Admin);
        }
        
        public System.Threading.Tasks.Task<string> RegistrationAsync(string Nome, string Cognome, string Utente, string Password, bool Admin) {
            return base.Channel.RegistrationAsync(Nome, Cognome, Utente, Password, Admin);
        }
        
        public bool UserChecker(string Utente) {
            return base.Channel.UserChecker(Utente);
        }
        
        public System.Threading.Tasks.Task<bool> UserCheckerAsync(string Utente) {
            return base.Channel.UserCheckerAsync(Utente);
        }
        
        public bool Login(string Utente, string Password, bool Admin) {
            return base.Channel.Login(Utente, Password, Admin);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string Utente, string Password, bool Admin) {
            return base.Channel.LoginAsync(Utente, Password, Admin);
        }
        
        public string AddBooking(string Utente, System.DateTime Date, System.DateTime Time) {
            return base.Channel.AddBooking(Utente, Date, Time);
        }
        
        public System.Threading.Tasks.Task<string> AddBookingAsync(string Utente, System.DateTime Date, System.DateTime Time) {
            return base.Channel.AddBookingAsync(Utente, Date, Time);
        }
        
        public string UserPasswordChange(string Utente, string Password) {
            return base.Channel.UserPasswordChange(Utente, Password);
        }
        
        public System.Threading.Tasks.Task<string> UserPasswordChangeAsync(string Utente, string Password) {
            return base.Channel.UserPasswordChangeAsync(Utente, Password);
        }
    }
}
