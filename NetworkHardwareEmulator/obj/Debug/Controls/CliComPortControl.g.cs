#pragma checksum "..\..\..\Controls\CliComPortControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7398EAB18891B6E9B161B460FABED57A81D835257E65AD7CDA1E802B297103CF"
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
    /// CliComPortControl
    /// </summary>
    public partial class CliComPortControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CliComPortImg;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CliComPortName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SuccessfulLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CliComPortTheory;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CliComPortWork;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\CliComPortControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CliComPortTest;
        
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
            System.Uri resourceLocater = new System.Uri("/NetworkHardwareEmulator;component/controls/clicomportcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\CliComPortControl.xaml"
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
            this.CliComPortImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.CliComPortName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.SuccessfulLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CliComPortTheory = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Controls\CliComPortControl.xaml"
            this.CliComPortTheory.Click += new System.Windows.RoutedEventHandler(this.CliComPortTheory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CliComPortWork = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Controls\CliComPortControl.xaml"
            this.CliComPortWork.Click += new System.Windows.RoutedEventHandler(this.CliComPortWork_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CliComPortTest = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Controls\CliComPortControl.xaml"
            this.CliComPortTest.Click += new System.Windows.RoutedEventHandler(this.CliComPortTest_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

