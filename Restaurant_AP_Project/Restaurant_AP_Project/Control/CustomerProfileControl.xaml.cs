using Restaurant_AP_Project.Model;
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
        public Customer Customer { get; set; }

        public Color btnColor = Color.FromRgb(50, 255, 150);
        public CustomerProfileControl(Customer customer)
        {
            Customer = customer;
            InitializeComponent();
            DataContext = this;
            this.Loaded += CustomerProfileControl_Loaded;
        }

        private void CustomerProfileControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            if (Customer != null)
            {
                uinfoName.txtBox.Text = Customer.Name;
                uinfoLastName.txtBox.Text = Customer.LastName;
                uinfoPhone.txtBox.Text = Customer.Phone;
                uinfoEmail.txtBox.Text = Customer.Email;
                uinfoUserName.txtBox.Text = Customer.UserName;
                uinfoAddress.txtBox.Text = Customer.Address;
                cmbGender.SelectedIndex = (int)Customer.gender;
                cmbService.SelectedIndex = (int)Customer.Service;
            }
        }

        private void btnAddressChange(object sender, RoutedEventArgs e)
        {
            if (!uinfoAddress.txtBox.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                uinfoAddress.txtBox.IsEnabled = true;
            }
            else
            {
                Customer.Address = uinfoAddress.BoxText;
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ویرایش";
                uinfoAddress.txtBox.IsEnabled = false;
            }
        }

        private void btnEmailChange(object sender, RoutedEventArgs e)
        {

            if (!uinfoEmail.txtBox.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";

                uinfoEmail.txtBox.IsEnabled = true;
            }
            else
            {
                try
                {
                    uinfoEmail.BoxText.IsCorrectEmail();
                    Customer.Email = uinfoEmail.BoxText;

                    (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                    (sender as Button).Content = "ویرایش";
                    uinfoEmail.txtBox.IsEnabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
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

        private void GenderChange(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not null && (sender as ComboBox).IsEnabled)
            {
                Customer.gender = (Customer.Gender)(sender as ComboBox).SelectedIndex;
            }

        }

        private void btnGenderChange(object sender, RoutedEventArgs e)
        {
            if (!cmbGender.IsEnabled)
            {
                (sender as Button).Background = new SolidColorBrush(btnColor);
                (sender as Button).Content = "تایید";
                cmbGender.IsEnabled = true;
            }
            else
            {
                (sender as Button).Background = (Brush)FindResource("BlueVioletBrush");
                (sender as Button).Content = "ویرایش";
                cmbGender.IsEnabled = false;
            }
        }

        private void SpecialServiceChange(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not null && (sender as ComboBox).IsEnabled)
            {
                Customer.Service = (Customer.SpecialService)(sender as ComboBox).SelectedIndex;
            }
        }
    }
}
