﻿#pragma checksum "D:\Working\WordBank\Source\WorldMap\Workspace.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D0E48E7C74410411BDF7E5FC5B166D90"
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
using WorldMap;


namespace WorldMap {
    
    
    public partial class Workspace : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TabControl MainTabControl;
        
        internal System.Windows.Controls.TabItem NavigationTabItem;
        
        internal System.Windows.Controls.RadioButton RoadModeRadioButton;
        
        internal System.Windows.Controls.RadioButton AerialModeRadioButton;
        
        internal System.Windows.Controls.RadioButton AerialWithLablesCheckBox;
        
        internal System.Windows.Controls.CheckBox ShowPushpinLayerCheckBox;
        
        internal System.Windows.Controls.CheckBox ShowMarkupLayerCheckBox;
        
        internal System.Windows.Controls.CheckBox ShowTradeDataLayerCheckBox;
        
        internal System.Windows.Controls.TabItem SearchTabItem;
        
        internal System.Windows.Controls.ComboBox IndicatorComboBox;
        
        internal System.Windows.Controls.ComboBox YearComboBox;
        
        internal System.Windows.Controls.TextBox FromValueTextBox;
        
        internal System.Windows.Controls.TextBox ToValueTextBox;
        
        internal System.Windows.Controls.Button SearchCountryByIndicatorsButton;
        
        internal System.Windows.Controls.ListBox SearchByIndicatorResultListBox;
        
        internal System.Windows.Controls.TabItem CountryTabItem;
        
        internal WorldMap.CountryDetails CountryDetailsControl;
        
        internal WorldMap.CompareCountriesChildWindow CompareControl;
        
        internal WorldMap.TradeMode TradeDataControl;
        
        internal System.Windows.Controls.TabItem ShortcutTab;
        
        internal System.Windows.Controls.ListBox ShortcutListBox;
        
        internal System.Windows.Controls.Accordion IndicatorsAccordion;
        
        internal System.Windows.Controls.Button SaveIndicatorButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WorldMap;component/Workspace.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MainTabControl = ((System.Windows.Controls.TabControl)(this.FindName("MainTabControl")));
            this.NavigationTabItem = ((System.Windows.Controls.TabItem)(this.FindName("NavigationTabItem")));
            this.RoadModeRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("RoadModeRadioButton")));
            this.AerialModeRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("AerialModeRadioButton")));
            this.AerialWithLablesCheckBox = ((System.Windows.Controls.RadioButton)(this.FindName("AerialWithLablesCheckBox")));
            this.ShowPushpinLayerCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("ShowPushpinLayerCheckBox")));
            this.ShowMarkupLayerCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("ShowMarkupLayerCheckBox")));
            this.ShowTradeDataLayerCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("ShowTradeDataLayerCheckBox")));
            this.SearchTabItem = ((System.Windows.Controls.TabItem)(this.FindName("SearchTabItem")));
            this.IndicatorComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("IndicatorComboBox")));
            this.YearComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("YearComboBox")));
            this.FromValueTextBox = ((System.Windows.Controls.TextBox)(this.FindName("FromValueTextBox")));
            this.ToValueTextBox = ((System.Windows.Controls.TextBox)(this.FindName("ToValueTextBox")));
            this.SearchCountryByIndicatorsButton = ((System.Windows.Controls.Button)(this.FindName("SearchCountryByIndicatorsButton")));
            this.SearchByIndicatorResultListBox = ((System.Windows.Controls.ListBox)(this.FindName("SearchByIndicatorResultListBox")));
            this.CountryTabItem = ((System.Windows.Controls.TabItem)(this.FindName("CountryTabItem")));
            this.CountryDetailsControl = ((WorldMap.CountryDetails)(this.FindName("CountryDetailsControl")));
            this.CompareControl = ((WorldMap.CompareCountriesChildWindow)(this.FindName("CompareControl")));
            this.TradeDataControl = ((WorldMap.TradeMode)(this.FindName("TradeDataControl")));
            this.ShortcutTab = ((System.Windows.Controls.TabItem)(this.FindName("ShortcutTab")));
            this.ShortcutListBox = ((System.Windows.Controls.ListBox)(this.FindName("ShortcutListBox")));
            this.IndicatorsAccordion = ((System.Windows.Controls.Accordion)(this.FindName("IndicatorsAccordion")));
            this.SaveIndicatorButton = ((System.Windows.Controls.Button)(this.FindName("SaveIndicatorButton")));
        }
    }
}
