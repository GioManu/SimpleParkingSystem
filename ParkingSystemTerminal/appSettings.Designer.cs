﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkingSystemTerminal {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class appSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static appSettings defaultInstance = ((appSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new appSettings())));
        
        public static appSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\ParkMode.ini")]
        public string ModeFile {
            get {
                return ((string)(this["ModeFile"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int QRCodeSize {
            get {
                return ((int)(this["QRCodeSize"]));
            }
            set {
                this["QRCodeSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Ticket.jpg")]
        public string TicketFile {
            get {
                return ((string)(this["TicketFile"]));
            }
            set {
                this["TicketFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d/MM/yyyy HH:mm")]
        public string TicketDateFormat {
            get {
                return ((string)(this["TicketDateFormat"]));
            }
            set {
                this["TicketDateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HEADER")]
        public string Header {
            get {
                return ((string)(this["Header"]));
            }
            set {
                this["Header"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double Tariff {
            get {
                return ((double)(this["Tariff"]));
            }
            set {
                this["Tariff"] = value;
            }
        }
    }
}
