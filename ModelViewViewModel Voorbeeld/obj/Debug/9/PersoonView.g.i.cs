﻿#pragma checksum "..\..\..\9\PersoonView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F55FAA443F819D5591C6C429ABCB4E85484656F8603D47DB7EDC0E664DB9E22E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ModelViewViewModel_Voorbeeld.Stap8;
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


namespace ModelViewViewModel_Voorbeeld.Stap8 {
    
    
    /// <summary>
    /// PersoonView
    /// </summary>
    public partial class PersoonView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaam;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbErrorNaam;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLeeftijd;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbErrorLeeftijd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsMannelijk;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToon;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\9\PersoonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVeranderInCode;
        
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
            System.Uri resourceLocater = new System.Uri("/ModelViewViewModel Voorbeeld;component/9/persoonview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\9\PersoonView.xaml"
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
            this.txtNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbErrorNaam = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtLeeftijd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbErrorLeeftijd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.IsMannelijk = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnToon = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnVeranderInCode = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

