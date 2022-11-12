﻿#pragma checksum "..\..\..\..\IFCEntityTree\EntityTree.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FE5BCA4B3F9BF742D26C79382070E40813FDEA60F1E4AD735767400B877D844"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Autodesk.UI.Windows;
using BIM.IFC.Export.UI.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace BIM.IFC.Export.UI {
    
    
    /// <summary>
    /// EntityTree
    /// </summary>
    public partial class EntityTree : Autodesk.UI.Windows.ChildWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Main;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_IFCSchema;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_IFCSchema;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView IFCEntityTreeView;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView PredefinedTypeTreeView;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Search;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Search;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Help;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run HelpRun;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ExpandAll;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CollapseAll;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Show;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_ShowItems;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Reset;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_OK;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/LoggerIFCExportUIOverride;component/ifcentitytree/entitytree.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
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
            this.Grid_Main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Label_IFCSchema = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ComboBox_IFCSchema = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.ComboBox_IFCSchema.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_IFCSchema_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IFCEntityTreeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 36 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.IFCEntityTreeView.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.IFCEntityTreeView_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PredefinedTypeTreeView = ((System.Windows.Controls.TreeView)(target));
            return;
            case 6:
            this.Label_Search = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.textBox_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.textBox_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlock_Help = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 44 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.OnHelpClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.HelpRun = ((System.Windows.Documents.Run)(target));
            return;
            case 11:
            this.button_ExpandAll = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.button_ExpandAll.Click += new System.Windows.RoutedEventHandler(this.button_ExpandAll_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.button_CollapseAll = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.button_CollapseAll.Click += new System.Windows.RoutedEventHandler(this.button_CollapseAll_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.label_Show = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.comboBox_ShowItems = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.comboBox_ShowItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_ShowItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.button_Reset = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.button_Reset.Click += new System.Windows.RoutedEventHandler(this.button_Reset_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Button_OK = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.Button_OK.Click += new System.Windows.RoutedEventHandler(this.Button_OK_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\IFCEntityTree\EntityTree.xaml"
            this.Button_Cancel.Click += new System.Windows.RoutedEventHandler(this.Button_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
