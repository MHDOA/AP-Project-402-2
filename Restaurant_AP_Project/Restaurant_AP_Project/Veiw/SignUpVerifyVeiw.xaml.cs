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
    /// Interaction logic for SignUpVerifyVeiw.xaml
    /// </summary>
    public partial class SignUpVerifyVeiw : Window
    {
        string name, lastName, phone, email, userName;
        string verifyCode;
        int id;
        public SignUpVerifyVeiw(int id, string name, string lastName, string phone, string email, string userName, string verifyCode)
        {
            InitializeComponent();
            this.name = name;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.userName = userName;
            this.verifyCode = verifyCode;
        }

        private void AddCustomer(Customer customer)
        {

        }

        private void btnVerify(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtVerifyCode.Text != verifyCode)
                    throw new Exception("کد تایید نامعتبر میباشد");

                txtPass.Password.ToString().Trim().IsCorrectPass();
                if (txtPass.Password != txtPassDup.Password)
                    throw new Exception("رمز ورود و تکرار آن باهم تطابق ندارند");

                AddCustomer(new Customer(id, name, lastName, email, Customer.SpecialService.None, Customer.Gender.Male, phone,
                    userName, txtPass.Password, "", new List<Order>(), new List<Complaint>(), new List<Comment>()));

                LoginVeiw loginVeiw = new LoginVeiw();
                loginVeiw.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBack(object sender, RoutedEventArgs e)
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

        private void MouseDownMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
