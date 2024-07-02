using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Restaurant_AP_Project.Control
{
    /// <summary>
    /// Interaction logic for CustomerProfileControl.xaml
    /// </summary>
    public partial class CustomerProfileControl : UserControl
    {
        public Color btnColor = Color.FromRgb(50, 255, 150);
        public CustomerProfileControl()
        {
            InitializeComponent();
            cmbService.SelectedIndex = 0;
        }

        private void btnAddressChange(object sender, RoutedEventArgs e)
        {
            if (!txtAddress.txtBox.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                txtAddress.txtBox.IsEnabled = true;
            }
            else
            {
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ویرایش";
                txtAddress.txtBox.IsEnabled = false;
            }
        }

        private void btnEmailChange(object sender, RoutedEventArgs e)
        {
            
            if (!txtEmail.txtBox.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                txtEmail.txtBox.IsEnabled = true;
            }
            else
            {
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ویرایش";
                txtEmail.txtBox.IsEnabled = false;
            }
        }

        private void btnGenderChange(object sender, RoutedEventArgs e)
        {
            if (!txtGender.txtBox.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                txtGender.txtBox.IsEnabled = true;
            }
            else
            {
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ویرایش";
                txtGender.txtBox.IsEnabled = false;
            }
        }

        private void btnSpecialServiceUpgrade(object sender, RoutedEventArgs e)
        {
            if (!cmbService.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                cmbService.IsEnabled = true;
            }
            else
            {
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ارتقا";
                cmbService.IsEnabled = false;
            }
        }
    }
}
