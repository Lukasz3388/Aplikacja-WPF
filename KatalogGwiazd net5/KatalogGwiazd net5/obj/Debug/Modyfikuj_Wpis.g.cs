#pragma checksum "..\..\Modyfikuj_Wpis.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88B19BD26E415251376B17C2179FB18E030D24AF458FF8B9770E95F7E7B8F0BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using KatalogGwiazd_net5;
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


namespace KatalogGwiazd_net5 {
    
    
    /// <summary>
    /// Modyfikuj_Wpis
    /// </summary>
    public partial class Modyfikuj_Wpis : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tytul_Modifukuj;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Content_Modyfikuj;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Modyfikuj_zdjecie;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZapisz;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZdjecie;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Modyfikuj_Wpis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnuluj;
        
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
            System.Uri resourceLocater = new System.Uri("/KatalogGwiazd net5;component/modyfikuj_wpis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modyfikuj_Wpis.xaml"
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
            this.Tytul_Modifukuj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Content_Modyfikuj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Modyfikuj_zdjecie = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.btnZapisz = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Modyfikuj_Wpis.xaml"
            this.btnZapisz.Click += new System.Windows.RoutedEventHandler(this.btnZapisz_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnZdjecie = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Modyfikuj_Wpis.xaml"
            this.btnZdjecie.Click += new System.Windows.RoutedEventHandler(this.btnZdjecie_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAnuluj = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Modyfikuj_Wpis.xaml"
            this.btnAnuluj.Click += new System.Windows.RoutedEventHandler(this.btnAnuluj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

