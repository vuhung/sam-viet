﻿#pragma checksum "D:\Working\WordBank\Source\WorldMap\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DD30E8AE6F5074C7A05754C1705FDFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Maps.MapControl;
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
using WorldMap;


namespace WorldMap {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl userControl;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Maps.MapControl.Map MyMap;
        
        internal Microsoft.Maps.MapControl.MapLayer ArrowLayer;
        
        internal Microsoft.Maps.MapControl.MapLayer PolygonLayer;
        
        internal Microsoft.Maps.MapControl.MapLayer MarkCountryLayer;
        
        internal Microsoft.Maps.MapControl.MapLayer PushPinLayer;
        
        internal System.Windows.Controls.StackPanel PushPinPanel;
        
        internal WorldMap.Workspace MyWorkSpace;
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.Border CountryListBorder;
        
        internal System.Windows.Controls.ListBox CountryListBox;
        
        internal System.Windows.Controls.Button SaveCountry;
        
        internal System.Windows.Controls.Primitives.ToggleButton HelpToggleButton;
        
        internal System.Windows.Controls.Primitives.ToggleButton SignInOut;
        
        internal System.Windows.Controls.TextBlock SignInInformation;
        
        internal WorldMap.ProjectViewer ProjectDetailControl;
        
        internal System.Windows.Controls.BusyIndicator loadingIndicator;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WorldMap;component/MainPage.xaml", System.UriKind.Relative));
            this.userControl = ((System.Windows.Controls.UserControl)(this.FindName("userControl")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MyMap = ((Microsoft.Maps.MapControl.Map)(this.FindName("MyMap")));
            this.ArrowLayer = ((Microsoft.Maps.MapControl.MapLayer)(this.FindName("ArrowLayer")));
            this.PolygonLayer = ((Microsoft.Maps.MapControl.MapLayer)(this.FindName("PolygonLayer")));
            this.MarkCountryLayer = ((Microsoft.Maps.MapControl.MapLayer)(this.FindName("MarkCountryLayer")));
            this.PushPinLayer = ((Microsoft.Maps.MapControl.MapLayer)(this.FindName("PushPinLayer")));
            this.PushPinPanel = ((System.Windows.Controls.StackPanel)(this.FindName("PushPinPanel")));
            this.MyWorkSpace = ((WorldMap.Workspace)(this.FindName("MyWorkSpace")));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.CountryListBorder = ((System.Windows.Controls.Border)(this.FindName("CountryListBorder")));
            this.CountryListBox = ((System.Windows.Controls.ListBox)(this.FindName("CountryListBox")));
            this.SaveCountry = ((System.Windows.Controls.Button)(this.FindName("SaveCountry")));
            this.HelpToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("HelpToggleButton")));
            this.SignInOut = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("SignInOut")));
            this.SignInInformation = ((System.Windows.Controls.TextBlock)(this.FindName("SignInInformation")));
            this.ProjectDetailControl = ((WorldMap.ProjectViewer)(this.FindName("ProjectDetailControl")));
            this.loadingIndicator = ((System.Windows.Controls.BusyIndicator)(this.FindName("loadingIndicator")));
        }
    }
}
