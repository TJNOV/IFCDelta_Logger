﻿#pragma checksum "..\..\..\IFCExport.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6564286665DF042BC24F8883A9047813AA9E4AD1297B9DEE6CEE3831C6C28489"
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
    /// IFCExport
    /// </summary>
    public partial class IFCExport : Autodesk.UI.Windows.ChildWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_FileName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSetupFileName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBrowse;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox currentSelectedSetup;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEditSetup;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSetupDescription;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewDocuments;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNext;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSetupCoordinateBase;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_ProjectLocation;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\IFCExport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSetupProjectLocation;
        
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
            System.Uri resourceLocater = new System.Uri("/LoggerIFCExportUIOverride;component/ifcexport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IFCExport.xaml"
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
            
            #line 13 "..\..\..\IFCExport.xaml"
            ((BIM.IFC.Export.UI.IFCExport)(target)).ContentRendered += new System.EventHandler(this.ChildWindow_ContentRendered);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\IFCExport.xaml"
            ((BIM.IFC.Export.UI.IFCExport)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label_FileName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxSetupFileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttonBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\IFCExport.xaml"
            this.buttonBrowse.Click += new System.Windows.RoutedEventHandler(this.buttonBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.currentSelectedSetup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\IFCExport.xaml"
            this.currentSelectedSetup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.currentSelectedSetup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonEditSetup = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\IFCExport.xaml"
            this.buttonEditSetup.Click += new System.Windows.RoutedEventHandler(this.buttonEditSetup_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.textBoxSetupDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\IFCExport.xaml"
            this.textBoxSetupDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxSetupDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label1_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.listViewDocuments = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            
            #line 39 "..\..\..\IFCExport.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.OnHelpClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.buttonNext = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\IFCExport.xaml"
            this.buttonNext.Click += new System.Windows.RoutedEventHandler(this.buttonExport_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\IFCExport.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.label1_Copy2 = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.textBoxSetupCoordinateBase = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\IFCExport.xaml"
            this.textBoxSetupCoordinateBase.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxSetupDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.label_ProjectLocation = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.textBoxSetupProjectLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

