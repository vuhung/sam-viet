﻿#pragma checksum "D:\Working\WordBank\Source\WorldMap\Workspace_Demo1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D767D5DFEB1B3C8E212815D17E17735"
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
    
    
    public partial class Workspace_demo1 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid MainContent;
        
        internal System.Windows.VisualStateGroup ArrowPosition;
        
        internal System.Windows.VisualState ClockActive;
        
        internal System.Windows.VisualState CountdownActive;
        
        internal System.Windows.VisualState TimerActive;
        
        internal System.Windows.VisualState WorldActive;
        
        internal System.Windows.Controls.Border BackgroundBorder;
        
        internal System.Windows.Controls.Grid TimeContent;
        
        internal System.Windows.Controls.StackPanel Menu;
        
        internal System.Windows.Controls.RadioButton news;
        
        internal System.Windows.Controls.RadioButton project;
        
        internal System.Windows.Controls.RadioButton statistic;
        
        internal System.Windows.Controls.RadioButton World;
        
        internal System.Windows.Controls.Grid Timers;
        
        internal System.Windows.Controls.Border TimeBackground;
        
        internal System.Windows.Controls.Border NewsBorder;
        
        internal System.Windows.Controls.StackPanel NewsContent;
        
        internal WorldMap.FeedViewer MyFeedViewer;
        
        internal System.Windows.Controls.Border ProjectBorder;
        
        internal System.Windows.Controls.Grid countdownContent;
        
        internal Microsoft.Maps.MapControl.Map MyMap;
        
        internal System.Windows.Controls.Border timerBorder;
        
        internal System.Windows.Controls.Grid timerContent;
        
        internal System.Windows.Shapes.Path arrowMenu;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WorldMap;component/Workspace_Demo1.xaml", System.UriKind.Relative));
            this.MainContent = ((System.Windows.Controls.Grid)(this.FindName("MainContent")));
            this.ArrowPosition = ((System.Windows.VisualStateGroup)(this.FindName("ArrowPosition")));
            this.ClockActive = ((System.Windows.VisualState)(this.FindName("ClockActive")));
            this.CountdownActive = ((System.Windows.VisualState)(this.FindName("CountdownActive")));
            this.TimerActive = ((System.Windows.VisualState)(this.FindName("TimerActive")));
            this.WorldActive = ((System.Windows.VisualState)(this.FindName("WorldActive")));
            this.BackgroundBorder = ((System.Windows.Controls.Border)(this.FindName("BackgroundBorder")));
            this.TimeContent = ((System.Windows.Controls.Grid)(this.FindName("TimeContent")));
            this.Menu = ((System.Windows.Controls.StackPanel)(this.FindName("Menu")));
            this.news = ((System.Windows.Controls.RadioButton)(this.FindName("news")));
            this.project = ((System.Windows.Controls.RadioButton)(this.FindName("project")));
            this.statistic = ((System.Windows.Controls.RadioButton)(this.FindName("statistic")));
            this.World = ((System.Windows.Controls.RadioButton)(this.FindName("World")));
            this.Timers = ((System.Windows.Controls.Grid)(this.FindName("Timers")));
            this.TimeBackground = ((System.Windows.Controls.Border)(this.FindName("TimeBackground")));
            this.NewsBorder = ((System.Windows.Controls.Border)(this.FindName("NewsBorder")));
            this.NewsContent = ((System.Windows.Controls.StackPanel)(this.FindName("NewsContent")));
            this.MyFeedViewer = ((WorldMap.FeedViewer)(this.FindName("MyFeedViewer")));
            this.ProjectBorder = ((System.Windows.Controls.Border)(this.FindName("ProjectBorder")));
            this.countdownContent = ((System.Windows.Controls.Grid)(this.FindName("countdownContent")));
            this.MyMap = ((Microsoft.Maps.MapControl.Map)(this.FindName("MyMap")));
            this.timerBorder = ((System.Windows.Controls.Border)(this.FindName("timerBorder")));
            this.timerContent = ((System.Windows.Controls.Grid)(this.FindName("timerContent")));
            this.arrowMenu = ((System.Windows.Shapes.Path)(this.FindName("arrowMenu")));
        }
    }
}

