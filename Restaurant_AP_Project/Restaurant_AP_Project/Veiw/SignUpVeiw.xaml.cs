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
    /// Interaction logic for SignUpVeiw.xaml
    /// </summary>
    public partial class SignUpVeiw : Window
    {
        List<Customer> customers = new List<Customer>();

        private void LoadData()
        {

        }

        private void SendEmail(string str)
        {

        }

        public SignUpVeiw()
        {
            InitializeComponent();
            LoadData();
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
            try
            {
                // Input Validity
                txtName.Text.IsCorrectName("نام");
                txtLastName.Text.IsCorrectName("نام خانوادگی");
                txtPhone.Text.IsCorrectPhone();
                txtEmail.Text.IsCorrectEmail();
                txtUsername.Text.IsCorrectUserName();

                // Unique Username and Phone
                var dupUserName = customers.Where(x => x.UserName == txtUsername.Text.Trim()).ToList();
                if (dupUserName.Count > 0)
                    throw new Exception("نام کاربری باید یکتا باشد");

                var dupPhone = customers.Where(x => x.Phone == txtPhone.Text.Trim()).ToList();
                if (dupPhone.Count > 0)
                    throw new Exception("شماره همراه باید یکتا باشد");

                // Create Verify Code
                Random rand = new Random();
                string verifyCode = rand.Next(1000, 9999).ToString();
                SendEmail(verifyCode);

                // Create Customer Id
                int id;
                do
                {
                    id = Guid.NewGuid().GetHashCode();
                }while(id <= 0 || customers.Where(x => x.Id == id).Count() > 0);

                SignUpVerifyVeiw signUpVerifyVeiw = new SignUpVerifyVeiw(id, txtName.Text.Trim(), txtLastName.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim(), txtUsername.Text.Trim(), verifyCode);
                signUpVerifyVeiw.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            LoginVeiw loginVeiw = new LoginVeiw();
            loginVeiw.Show();
            Close();
        }
    }
}
