﻿#pragma checksum "..\..\..\Pages\Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "60E11C3EA422AA025026662E3F31025A205F089564F2BF2A9795AB584662706F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WordSkills.Pages;


namespace WordSkills.Pages {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxLogin;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPassword;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbxShowPass;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CapchaBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPanelSymbols;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CanvasNoise;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaptchaGet;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateCaptcha;
        
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
            System.Uri resourceLocater = new System.Uri("/WordSkills;component/pages/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Login.xaml"
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
            this.textboxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxbPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PassBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.TbxShowPass = ((System.Windows.Controls.TextBlock)(target));
            
            #line 19 "..\..\..\Pages\Login.xaml"
            this.TbxShowPass.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TbxShowPass_MouseDown);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\Pages\Login.xaml"
            this.TbxShowPass.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TbxShowPass_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\..\Pages\Login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CapchaBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.SPanelSymbols = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.CanvasNoise = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.CaptchaGet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.BtnUpdateCaptcha = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Login.xaml"
            this.BtnUpdateCaptcha.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateCaptcha_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

