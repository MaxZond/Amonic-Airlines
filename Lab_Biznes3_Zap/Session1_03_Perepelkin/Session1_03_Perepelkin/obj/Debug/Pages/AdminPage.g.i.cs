#pragma checksum "..\..\..\Pages\AdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "80E1F49D7A26DFED3EBC92E1F5B44DB6DCB43CAECF333CCC0250E42C8FF69E20"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AMONIC_Airlines_3;
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


namespace Session1_03_Perepelkin.Pages {
    
    
    /// <summary>
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUserButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OfficeTB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OfficeComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserGrid;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn EmailColumn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeRoleButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnDisEnButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Session1_03_Perepelkin;component/pages/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminPage.xaml"
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
            
            #line 9 "..\..\..\Pages\AdminPage.xaml"
            ((Session1_03_Perepelkin.Pages.AdminPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Pages\AdminPage.xaml"
            ((Session1_03_Perepelkin.Pages.AdminPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\AdminPage.xaml"
            this.AddUserButton.Click += new System.Windows.RoutedEventHandler(this.AddUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\AdminPage.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.AddUserButton_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OfficeTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.OfficeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Pages\AdminPage.xaml"
            this.OfficeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OfficeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UserGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 42 "..\..\..\Pages\AdminPage.xaml"
            this.UserGrid.GotFocus += new System.Windows.RoutedEventHandler(this.UserGrid_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\Pages\AdminPage.xaml"
            this.UserGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.UserGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EmailColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.ChangeRoleButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Pages\AdminPage.xaml"
            this.ChangeRoleButton.Click += new System.Windows.RoutedEventHandler(this.ChangeRoleButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EnDisEnButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Pages\AdminPage.xaml"
            this.EnDisEnButton.Click += new System.Windows.RoutedEventHandler(this.EnDisEnButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

