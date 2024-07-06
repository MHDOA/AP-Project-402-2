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
    /// Interaction logic for RestaurantControl.xaml
    /// </summary>
    public partial class RestaurantControl : UserControl
    {
        public RestaurantControl()
        {
            InitializeComponent();
            txtUserName.Visibility = Visibility.Collapsed;
            txtUserNameValue.Visibility = Visibility.Collapsed;
        }
        public string RestaurantName
        {
            get { return txtName.Text; }
            set { txtNameValue.Text = value; }
        }

        public string Username
        {
            get { return txtUserNameValue.Text; }
            set { txtUserNameValue.Text = value; }
        }

        public string ReceptionType
        {
            get { return txtReceptionTypeValue.Text; }
            set { txtReceptionTypeValue.Text = value; }
        }

        public string Score
        {
            get { return txtScoreValue.Text; }
            set { txtScoreValue.Text = value; }
        }

        public string Address
        {
            get { return txtAddressValue.Text; }
            set { txtAddressValue.Text = value; }
        }

        public string Categories
        {
            get { return txtCategoriesValue.Text; }
            set { txtCategoriesValue.Text = value; }
        }
    }
}
