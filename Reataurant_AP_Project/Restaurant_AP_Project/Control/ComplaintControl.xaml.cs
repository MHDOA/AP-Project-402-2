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
    /// Interaction logic for ComplaintControl.xaml
    /// </summary>
    public partial class ComplaintControl : UserControl
    {
        public string UserName
        {
            get { return txtUserNameValue.Text; }
            set { txtUserNameValue.Text = value; }
        }

        public string ComplaintTitle
        {
            get { return txtComplaintTitleValue.Text; }
            set { txtComplaintTitleValue.Text = value; }
        }

        public string Restaurant
        {
            get { return txtRestaurantValue.Text; }
            set { txtRestaurantValue.Text = value; }
        }

        public string Description
        {
            get { return txtDescriptionValue.Text; }
            set { txtDescriptionValue.Text = value; }
        }

        private bool _isAnswered;
        public bool IsAnswered
        {
            get { return _isAnswered; }
            set
            {
                _isAnswered = value;
                string answer = _isAnswered ? "برسی شده" : "برسی نشده";
                txtIsAnsweredValue.Text = answer;
            }
        }

        public ComplaintControl()
        {
            InitializeComponent();
        }
    }

}
