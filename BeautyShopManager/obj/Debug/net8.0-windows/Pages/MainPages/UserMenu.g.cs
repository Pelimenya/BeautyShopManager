﻿#pragma checksum "..\..\..\..\..\Pages\MainPages\UserMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70475D1F1A865D3235070E253E1A24763645DE35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautyShopManager.Pages.MainPages;
using MahApps.Metro.Controls;
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


namespace BeautyShopManager.Pages.MainPages {
    
    
    /// <summary>
    /// UserMenu
    /// </summary>
    public partial class UserMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.HamburgerMenu TableMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame EmployeesTable;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame LossesPage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame SalesPlanPage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame LoginPage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AboutPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BeautyShopManager;component/pages/mainpages/usermenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TableMenu = ((MahApps.Metro.Controls.HamburgerMenu)(target));
            
            #line 21 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
            this.TableMenu.ItemClick += new MahApps.Metro.Controls.ItemClickRoutedEventHandler(this.HamburgerMenuControl_OnItemClick);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\..\Pages\MainPages\UserMenu.xaml"
            this.TableMenu.OptionsItemClick += new MahApps.Metro.Controls.ItemClickRoutedEventHandler(this.HamburgerMenuControl_OnItemClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EmployeesTable = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.LossesPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.SalesPlanPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 5:
            this.LoginPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.AboutPage = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

