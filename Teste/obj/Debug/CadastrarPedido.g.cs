﻿#pragma checksum "..\..\CadastrarPedido.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF76B2DC8E3337698AA755C837E5CD6506785939"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using Teste;


namespace Teste {
    
    
    /// <summary>
    /// CadastrarPedido
    /// </summary>
    public partial class CadastrarPedido : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\CadastrarPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomePessoaTB;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\CadastrarPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPedido;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\CadastrarPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SalvarPedido;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\CadastrarPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelarPedido;
        
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
            System.Uri resourceLocater = new System.Uri("/Teste;component/cadastrarpedido.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CadastrarPedido.xaml"
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
            this.NomePessoaTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DataGridPedido = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.SalvarPedido = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\CadastrarPedido.xaml"
            this.SalvarPedido.Click += new System.Windows.RoutedEventHandler(this.SalvarPedido_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CancelarPedido = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\CadastrarPedido.xaml"
            this.CancelarPedido.Click += new System.Windows.RoutedEventHandler(this.CancelarPedido_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
