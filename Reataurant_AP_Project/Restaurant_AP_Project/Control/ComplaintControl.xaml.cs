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
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string ComplaintTitle
        {
            get { return txtComplaintTitle.Text; }
            set { txtComplaintTitle.Text = value; }
        }

        public string Restaurant
        {
            get { return txtRestaurant.Text; }
            set { txtRestaurant.Text = value; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        private bool _isAnswered;
        public bool IsAnswered
        {
            get { return _isAnswered; }
            set
            {
                _isAnswered = value;
                txtIsAnswered.Text = _isAnswered ? "برسی شده" : "برسی نشده";
            }
        }

        public ComplaintControl()
        {
            InitializeComponent();
        }
    }
}
