#pragma checksum "..\..\..\Windows\CliTelnetLab.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40A219F595C09F8B3756E25943071B9A5D59428EAAF416917BF10383E89CC8C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NetworkHardwareEmulator.Windows;
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


namespace NetworkHardwareEmulator.Windows {
    
    
    /// <summary>
    /// CliTelnetLab
    /// </summary>
    public partial class CliTelnetLab : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TcpIpConfig;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IpAdreesInput;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaskInput;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PuskPanel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PuskPanelInput;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\CliTelnetLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AgreeAnswer;
        
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
            System.Uri resourceLocater = new System.Uri("/NetworkHardwareEmulator;component/windows/clitelnetlab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\CliTelnetLab.xaml"
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
            this.TcpIpConfig = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.IpAdreesInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MaskInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PuskPanel = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.PuskPanelInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AgreeAnswer = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Windows\CliTelnetLab.xaml"
            this.AgreeAnswer.Click += new System.Windows.RoutedEventHandler(this.AgreeAnswer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

