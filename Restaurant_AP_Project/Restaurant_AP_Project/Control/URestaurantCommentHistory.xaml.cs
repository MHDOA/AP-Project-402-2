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
    /// Interaction logic for URestaurantCommentHistory.xaml
    /// </summary>
    public partial class URestaurantCommentHistory : UserControl
    {
        public string Comment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }

        public URestaurantCommentHistory()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler btnEditClick
        {
            add { btnEditComment.Click += value; }
            remove { btnEditComment.Click -= value; }
        }
    }
}
