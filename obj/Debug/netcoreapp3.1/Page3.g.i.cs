﻿#pragma checksum "..\..\..\Page3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98F01CF9D3B47B970373F80ACD0C6015C89F067D"
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
using System.Windows.Controls.Ribbon;
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
using Test_GP_App;


namespace Test_GP_App {
    
    
    /// <summary>
    /// Page3
    /// </summary>
    public partial class Page3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock receiptText;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalText;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock asapText;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pickUpText;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hoursUp;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tenMinUp;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minuteUp;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hoursDown;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tenMinDown;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minuteDown;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Test GP App;component/page3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.receiptText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 43 "..\..\..\Page3.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.back);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 57 "..\..\..\Page3.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pickup_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 58 "..\..\..\Page3.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.asap_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.totalText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.asapText = ((System.Windows.Controls.TextBlock)(target));
            
            #line 60 "..\..\..\Page3.xaml"
            this.asapText.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.asap_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pickUpText = ((System.Windows.Controls.TextBlock)(target));
            
            #line 61 "..\..\..\Page3.xaml"
            this.pickUpText.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pickup_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.hoursUp = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Page3.xaml"
            this.hoursUp.Click += new System.Windows.RoutedEventHandler(this.hourUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tenMinUp = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Page3.xaml"
            this.tenMinUp.Click += new System.Windows.RoutedEventHandler(this.tenUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.minuteUp = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Page3.xaml"
            this.minuteUp.Click += new System.Windows.RoutedEventHandler(this.minUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.hoursDown = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Page3.xaml"
            this.hoursDown.Click += new System.Windows.RoutedEventHandler(this.hourDn);
            
            #line default
            #line hidden
            return;
            case 12:
            this.tenMinDown = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Page3.xaml"
            this.tenMinDown.Click += new System.Windows.RoutedEventHandler(this.tenDn);
            
            #line default
            #line hidden
            return;
            case 13:
            this.minuteDown = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Page3.xaml"
            this.minuteDown.Click += new System.Windows.RoutedEventHandler(this.minDn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
