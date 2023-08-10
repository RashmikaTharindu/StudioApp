using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudioApp.CustomController
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        private static DependencyProperty passwordproperty = DependencyProperty.Register("Password", typeof(SecureString), typeof(BindablePasswordBox));
        public SecureString Password
        {
            get { return (SecureString)GetValue(passwordproperty); }
            set { SetValue(passwordproperty, value); }
        }
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtPass.PasswordChanged += OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs routedEventArgs)
        {
            Password= txtPass.SecurePassword;
        }
    }
}
