﻿#pragma checksum "C:\Users\Mats\Development\7Timer-Astro-Weather\AstroPanel\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04825550B90229F5B3BB77D92F39E91E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Primitives;
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


namespace SevenTimerAstroWeather {
    
    
    public partial class SettingsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal Microsoft.Phone.Controls.Primitives.ToggleSwitchButton GPSModeSwitch;
        
        internal System.Windows.Controls.TextBox LatitudeTextBox;
        
        internal System.Windows.Controls.TextBox LongitudeTextBox;
        
        internal System.Windows.Controls.RadioButton CelciusRadioButton;
        
        internal System.Windows.Controls.RadioButton FahrenheitRadioButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SevenTimerAstroWeather;component/SettingsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.GPSModeSwitch = ((Microsoft.Phone.Controls.Primitives.ToggleSwitchButton)(this.FindName("GPSModeSwitch")));
            this.LatitudeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("LatitudeTextBox")));
            this.LongitudeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("LongitudeTextBox")));
            this.CelciusRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("CelciusRadioButton")));
            this.FahrenheitRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("FahrenheitRadioButton")));
        }
    }
}
