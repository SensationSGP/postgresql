﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29AB3BEF3B70053B2A850169FF8EBB511709FE41"
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
using postgresql;


namespace postgresql {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal postgresql.MainWindow frmPrincipal;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridConexao;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtServer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPorta;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuario;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtSenhapostgre;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBD;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTeste;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbSenhaPadrao;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbSenhainstala;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTeste;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTesteConexao;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lblListaBD;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEmpresaBD;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmpresaBD;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridRenomeiaBD;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxListaBD;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtSenhalistaBD;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListarBD;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomeBD;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRenomearBD;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCriaBD;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCriarBD;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCriausuario;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridRestore;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLocalBD;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarBD;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRestore;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDownload;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridRestore_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/postgresql;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.frmPrincipal = ((postgresql.MainWindow)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.frmPrincipal.Loaded += new System.Windows.RoutedEventHandler(this.frmPrincipal_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridConexao = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtServer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPorta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtSenhapostgre = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.txtBD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.gridTeste = ((System.Windows.Controls.Grid)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.gridTeste.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gridTeste_MouseLeave);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.gridTeste.MouseMove += new System.Windows.Input.MouseEventHandler(this.gridTeste_MouseMove);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rbSenhaPadrao = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.rbSenhainstala = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.btnTeste = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.btnTeste.Click += new System.Windows.RoutedEventHandler(this.btnTeste_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lblTesteConexao = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.lblListaBD = ((System.Windows.Controls.ListBox)(target));
            return;
            case 14:
            this.lblEmpresaBD = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.txtEmpresaBD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.gridRenomeiaBD = ((System.Windows.Controls.Grid)(target));
            
            #line 70 "..\..\MainWindow.xaml"
            this.gridRenomeiaBD.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gridRenomeiaBD_MouseLeave);
            
            #line default
            #line hidden
            
            #line 70 "..\..\MainWindow.xaml"
            this.gridRenomeiaBD.MouseMove += new System.Windows.Input.MouseEventHandler(this.gridRenomeiaBD_MouseMove);
            
            #line default
            #line hidden
            return;
            case 17:
            this.cbxListaBD = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 18:
            this.txtSenhalistaBD = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 101 "..\..\MainWindow.xaml"
            this.txtSenhalistaBD.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtSenhalistaBD_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btnListarBD = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\MainWindow.xaml"
            this.btnListarBD.Click += new System.Windows.RoutedEventHandler(this.btnListarBD_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.txtNomeBD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.btnRenomearBD = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\MainWindow.xaml"
            this.btnRenomearBD.Click += new System.Windows.RoutedEventHandler(this.btnRenomearBD_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.gridCriaBD = ((System.Windows.Controls.Grid)(target));
            
            #line 118 "..\..\MainWindow.xaml"
            this.gridCriaBD.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gridCriaBD_MouseLeave);
            
            #line default
            #line hidden
            
            #line 118 "..\..\MainWindow.xaml"
            this.gridCriaBD.MouseMove += new System.Windows.Input.MouseEventHandler(this.gridCriaBD_MouseMove);
            
            #line default
            #line hidden
            return;
            case 23:
            this.btnCriarBD = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\MainWindow.xaml"
            this.btnCriarBD.Click += new System.Windows.RoutedEventHandler(this.btnCriarBD_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.btnCriausuario = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\MainWindow.xaml"
            this.btnCriausuario.Click += new System.Windows.RoutedEventHandler(this.btnCriausuario_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.gridRestore = ((System.Windows.Controls.Grid)(target));
            
            #line 160 "..\..\MainWindow.xaml"
            this.gridRestore.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gridRestore_MouseLeave);
            
            #line default
            #line hidden
            
            #line 160 "..\..\MainWindow.xaml"
            this.gridRestore.MouseMove += new System.Windows.Input.MouseEventHandler(this.gridRestore_MouseMove);
            
            #line default
            #line hidden
            return;
            case 26:
            this.txtLocalBD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.btnBuscarBD = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\MainWindow.xaml"
            this.btnBuscarBD.Click += new System.Windows.RoutedEventHandler(this.btnBuscarBD_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.btnRestore = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\MainWindow.xaml"
            this.btnRestore.Click += new System.Windows.RoutedEventHandler(this.btnRestore_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.btnDownload = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\MainWindow.xaml"
            this.btnDownload.Click += new System.Windows.RoutedEventHandler(this.btnDownload_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.gridRestore_Copy = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

