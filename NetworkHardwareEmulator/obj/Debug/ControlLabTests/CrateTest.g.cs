﻿#pragma checksum "..\..\..\ControlLabTests\CrateTest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C1918662B97721A6FA705468453888085A066BE42CFA11D5166E5C5D2D94E16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NetworkHardwareEmulator.ControlLabTests;
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


namespace NetworkHardwareEmulator.ControlLabTests {
    
    
    /// <summary>
    /// CrateTest
    /// </summary>
    public partial class CrateTest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ControlLabTests\CrateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirsAnswer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ControlLabTests\CrateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecondAnswer;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ControlLabTests\CrateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThirdAnswer;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ControlLabTests\CrateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AgreeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/NetworkHardwareEmulator;component/controllabtests/cratetest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ControlLabTests\CrateTest.xaml"
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
            this.FirsAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SecondAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ThirdAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AgreeButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\ControlLabTests\CrateTest.xaml"
            this.AgreeButton.Click += new System.Windows.RoutedEventHandler(this.AgreeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

