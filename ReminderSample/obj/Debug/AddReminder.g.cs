﻿#pragma checksum "D:\Users\Administrator\Desktop\lzy\ReminderSample\ReminderSample\AddReminder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEE8F511D4CE7BA5504A2CC2E8C9FB3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace ReminderSample {
    
    
    public partial class AddReminder : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock titleLabel;
        
        internal System.Windows.Controls.TextBox txbName;
        
        internal System.Windows.Controls.TextBlock contentLabel;
        
        internal System.Windows.Controls.TextBox txbPhoneNum;
        
        internal System.Windows.Controls.TextBlock beginTimeLabel;
        
        internal Microsoft.Phone.Controls.DatePicker beginDatePicker;
        
        internal Microsoft.Phone.Controls.TimePicker beginTimePicker;
        
        internal System.Windows.Controls.TextBlock expirationTimeLabel;
        
        internal Microsoft.Phone.Controls.DatePicker expirationDatePicker;
        
        internal Microsoft.Phone.Controls.TimePicker expirationTimePicker;
        
        internal System.Windows.Controls.RadioButton onceRadioButton;
        
        internal System.Windows.Controls.RadioButton weeklyRadioButton;
        
        internal System.Windows.Controls.RadioButton dailyRadioButton;
        
        internal System.Windows.Controls.RadioButton monthlyRadioButton;
        
        internal System.Windows.Controls.RadioButton endOfMonthRadioButton;
        
        internal System.Windows.Controls.RadioButton yearlyRadioButton;
        
        internal System.Windows.Controls.Button btnSelectPhone1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ReminderSample;component/AddReminder.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.titleLabel = ((System.Windows.Controls.TextBlock)(this.FindName("titleLabel")));
            this.txbName = ((System.Windows.Controls.TextBox)(this.FindName("txbName")));
            this.contentLabel = ((System.Windows.Controls.TextBlock)(this.FindName("contentLabel")));
            this.txbPhoneNum = ((System.Windows.Controls.TextBox)(this.FindName("txbPhoneNum")));
            this.beginTimeLabel = ((System.Windows.Controls.TextBlock)(this.FindName("beginTimeLabel")));
            this.beginDatePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("beginDatePicker")));
            this.beginTimePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("beginTimePicker")));
            this.expirationTimeLabel = ((System.Windows.Controls.TextBlock)(this.FindName("expirationTimeLabel")));
            this.expirationDatePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("expirationDatePicker")));
            this.expirationTimePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("expirationTimePicker")));
            this.onceRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("onceRadioButton")));
            this.weeklyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("weeklyRadioButton")));
            this.dailyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("dailyRadioButton")));
            this.monthlyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("monthlyRadioButton")));
            this.endOfMonthRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("endOfMonthRadioButton")));
            this.yearlyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("yearlyRadioButton")));
            this.btnSelectPhone1 = ((System.Windows.Controls.Button)(this.FindName("btnSelectPhone1")));
        }
    }
}

