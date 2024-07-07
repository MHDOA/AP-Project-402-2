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
using System.Windows.Shapes;

namespace Restaurant_AP_Project.Veiw
{
    /// <summary>
    /// Interaction logic for LoginVeiw.xaml
    /// </summary>
    public partial class LoginVeiw : Window
    {
        public List<Customer> customers = new List<Customer>();
        public List<Restaurant> restaurants = new List<Restaurant>();
        public List<Admin> admins = new List<Admin>();

        private void LoadData()
        {
            // Load Data Base
        }

        public LoginVeiw()
        {
            DataContext = this;
            InitializeComponent();
            LoadData();
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("نام کاربری نمیتواند خالی باشد");
                return;
            }

            if (String.IsNullOrEmpty(txtPass.Password.Trim()))
            {
                MessageBox.Show("رمز ورود نمیتواند خالی باشد");
                return;
            }

            Customer customer;
            try
            {
                customer = customers.Where(x => x.UserName == txtUsername.Text).First();

                if (customer.Password == txtPass.Password)
                {
                    CustomerMainVeiw customerMainVeiw = new CustomerMainVeiw(customer);
                    customerMainVeiw.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("رمز ورود اشتباه است");
                }
            }
            catch
            {
                Restaurant restaurant;
                try
                {
                    restaurant = restaurants.Where(x => x.UserName == txtUsername.Text).First();
                    if(restaurant.Pass == txtPass.Password)
                    {
                        RestaurantMainView restaurantMainView = new RestaurantMainView(restaurant);
                        restaurantMainView.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("رمز ورود اشتباه است");
                    }
                }
                catch
                {
                    Admin admin;
                    try
                    {
                        admin = admins.Where(x => x.UserName == txtUsername.Text).First();
                        if(admin.Password == txtPass.Password)
                        {
                            // TODO send admin to amdin main view
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("رمز ورود اشتباه است");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("نام کاربری نامعتبر است");
                    }
                }
            }
        }

        private void MouseDownMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnSignUp(object sender, RoutedEventArgs e)
        {
            SignUpVeiw signUpVeiw = new SignUpVeiw();
            signUpVeiw.Show();
            Close();
        }

        private void btnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }


}
