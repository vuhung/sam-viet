﻿#pragma checksum "D:\Working\WordBank\Source\WorldMap\Controls\CustomChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FDC3D18493E7573C0CC04C123DA6129"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WorldMap {
    
    
    public partial class CustomChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.ChildWindow chwPopUp;
        
        internal System.Windows.Controls.TabControl tabControl1;
        
        internal System.Windows.Controls.TabItem OverviewTab;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image Flag;
        
        internal System.Windows.Controls.TextBlock CountryNameTextBlock;
        
        internal System.Windows.Controls.TextBlock RegionNameTextBlock;
        
        internal System.Windows.Controls.TextBlock LendingTypeTextBlock;
        
        internal System.Windows.Controls.TextBlock IncomeLevelTextBLock;
        
        internal System.Windows.Controls.TabItem tabItem2;
        
        internal System.Windows.Controls.Grid columnChartTabContainer;
        
        internal System.Windows.Controls.Grid columnChartTab;
        
        internal System.Windows.Controls.Grid IndicatorsGrid;
        
        internal System.Windows.Controls.ListBox IndicatorListBox;
        
        internal System.Windows.Controls.ComboBox comboBoxRenderStyle;
        
        internal System.Windows.Controls.Button buttonRenderChart;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WorldMap;component/Controls/CustomChildWindow.xaml", System.UriKind.Relative));
            this.chwPopUp = ((System.Windows.Controls.ChildWindow)(this.FindName("chwPopUp")));
            this.tabControl1 = ((System.Windows.Controls.TabControl)(this.FindName("tabControl1")));
            this.OverviewTab = ((System.Windows.Controls.TabItem)(this.FindName("OverviewTab")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Flag = ((System.Windows.Controls.Image)(this.FindName("Flag")));
            this.CountryNameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("CountryNameTextBlock")));
            this.RegionNameTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("RegionNameTextBlock")));
            this.LendingTypeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("LendingTypeTextBlock")));
            this.IncomeLevelTextBLock = ((System.Windows.Controls.TextBlock)(this.FindName("IncomeLevelTextBLock")));
            this.tabItem2 = ((System.Windows.Controls.TabItem)(this.FindName("tabItem2")));
            this.columnChartTabContainer = ((System.Windows.Controls.Grid)(this.FindName("columnChartTabContainer")));
            this.columnChartTab = ((System.Windows.Controls.Grid)(this.FindName("columnChartTab")));
            this.IndicatorsGrid = ((System.Windows.Controls.Grid)(this.FindName("IndicatorsGrid")));
            this.IndicatorListBox = ((System.Windows.Controls.ListBox)(this.FindName("IndicatorListBox")));
            this.comboBoxRenderStyle = ((System.Windows.Controls.ComboBox)(this.FindName("comboBoxRenderStyle")));
            this.buttonRenderChart = ((System.Windows.Controls.Button)(this.FindName("buttonRenderChart")));
        }
    }
}

