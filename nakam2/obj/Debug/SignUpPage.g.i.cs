﻿#pragma checksum "C:\Users\littlemanz\Documents\Visual Studio 2012\Projects\NakamNakam\nakam2\SignUpPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EAEBA0FF5970A7353B435F7EBA5F226D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace nakam2 {
    
    
    public partial class SignUpPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage TextBoxFirstLook;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadTextBox TextBoxName;
        
        internal Telerik.Windows.Controls.RadTextBox TextBoxUsername;
        
        internal Telerik.Windows.Controls.RadTextBox TextBoxEmail;
        
        internal Telerik.Windows.Controls.RadPasswordBox PasswordBox;
        
        internal Telerik.Windows.Controls.RadListPicker ListPickerGender;
        
        internal Telerik.Windows.Controls.RadDatePicker radDatePicker;
        
        internal Telerik.Windows.Controls.RadBusyIndicator busyIndicator;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/nakam2;component/SignUpPage.xaml", System.UriKind.Relative));
            this.TextBoxFirstLook = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("TextBoxFirstLook")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TextBoxName = ((Telerik.Windows.Controls.RadTextBox)(this.FindName("TextBoxName")));
            this.TextBoxUsername = ((Telerik.Windows.Controls.RadTextBox)(this.FindName("TextBoxUsername")));
            this.TextBoxEmail = ((Telerik.Windows.Controls.RadTextBox)(this.FindName("TextBoxEmail")));
            this.PasswordBox = ((Telerik.Windows.Controls.RadPasswordBox)(this.FindName("PasswordBox")));
            this.ListPickerGender = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("ListPickerGender")));
            this.radDatePicker = ((Telerik.Windows.Controls.RadDatePicker)(this.FindName("radDatePicker")));
            this.busyIndicator = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("busyIndicator")));
        }
    }
}

