﻿#pragma checksum "..\..\..\AdminManageRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8F465A072590D66BF222C09625999C0380D49FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfHotelManagement;


namespace WpfHotelManagement {
    
    
    /// <summary>
    /// AdminManageRoom
    /// </summary>
    public partial class AdminManageRoom : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInstruction;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRooms;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRoomId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDetailDescription;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaxCapacity;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRoomStatus;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPricePerDay;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRoomType;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\AdminManageRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfHotelManagement;component/adminmanageroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminManageRoom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblInstruction = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dgRooms = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\..\AdminManageRoom.xaml"
            this.dgRooms.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgCustomers_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtRoomId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtRoomNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\AdminManageRoom.xaml"
            this.txtRoomNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDetailDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtMaxCapacity = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\AdminManageRoom.xaml"
            this.txtMaxCapacity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbRoomStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.txtPricePerDay = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\AdminManageRoom.xaml"
            this.txtPricePerDay.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbRoomType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\AdminManageRoom.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.BtnCreate_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\AdminManageRoom.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\AdminManageRoom.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

