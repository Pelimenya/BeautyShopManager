﻿#pragma checksum "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D53936A82FE13BDED21D9E1B88D94378A5B45889"
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
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.HamburgerMenu TableMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame OrderFrame;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame LoginPage;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BeautyShopManager;component/pages/mainpages/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
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
            
            #line 21 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
            this.TableMenu.ItemClick += new MahApps.Metro.Controls.ItemClickRoutedEventHandler(this.HamburgerMenuControl_OnItemClick);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\..\Pages\MainPages\AdminMenu.xaml"
            this.TableMenu.OptionsItemClick += new MahApps.Metro.Controls.ItemClickRoutedEventHandler(this.HamburgerMenuControl_OnItemClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.LoginPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.AboutPage = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

