﻿#pragma checksum "..\..\..\..\Pages\AddDevice\Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CEA01BBA93A532F48997CA180AB029AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TH_DeviceManager.Controls;
using TH_WPF;
using TH_WPF.LoadingAnimation;


namespace TH_DeviceManager.Pages.AddDevice {
    
    
    /// <summary>
    /// Page
    /// </summary>
    public partial class Page : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 117 "..\..\..\..\Pages\AddDevice\Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_TXT;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TH_DeviceManager;component/pages/adddevice/page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddDevice\Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.search_TXT = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\..\..\Pages\AddDevice\Page.xaml"
            this.search_TXT.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TXT_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 125 "..\..\..\..\Pages\AddDevice\Page.xaml"
            ((TH_WPF.Button_04)(target)).Clicked += new TH_WPF.Button_04.Clicked_Handler(this.Refresh_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 450 "..\..\..\..\Pages\AddDevice\Page.xaml"
            ((TH_WPF.Button_04)(target)).Clicked += new TH_WPF.Button_04.Clicked_Handler(this.Remove_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

