﻿#pragma checksum "..\..\..\Controls\CrateControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD95B8B0175181D882A3014E880583DDB0CE454CAC8F895702057F0DB402A2D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NetworkHardwareEmulator.Controls;
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


namespace NetworkHardwareEmulator.Controls {
    
    
    /// <summary>
    /// CrateControl
    /// </summary>
    public partial class CrateControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CrateImg;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CrateName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SuccessfulLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CrateTheory;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CrateWork;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Controls\CrateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CrateTest;
        
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
            System.Uri resourceLocater = new System.Uri("/NetworkHardwareEmulator;component/controls/cratecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\CrateControl.xaml"
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
            this.CrateImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.CrateName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.SuccessfulLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CrateTheory = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Controls\CrateControl.xaml"
            this.CrateTheory.Click += new System.Windows.RoutedEventHandler(this.CrateTheory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CrateWork = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Controls\CrateControl.xaml"
            this.CrateWork.Click += new System.Windows.RoutedEventHandler(this.CrateWork_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CrateTest = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Controls\CrateControl.xaml"
            this.CrateTest.Click += new System.Windows.RoutedEventHandler(this.CrateTest_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
