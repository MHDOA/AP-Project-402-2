using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Interaction logic for URestaurantOrderHistoryControl.xaml
    /// </summary>
    public partial class URestaurantOrderHistoryControl : UserControl
    {

        public string RestaurantName
        {
            get { return txtRestaurantName.Text; }
            set { txtRestaurantName.Text = value; }
        }

        public int Price
        {
            get { return int.Parse(txtPrice.BoxText); }
            set { txtPrice.BoxText = value.ToString(); }
        }

        public DateTime OrderDate
        {
            set { txtDate.BoxText = value.ToString(); }
        }

        //public event RoutedEventHandler btnCommentEdit
        //{
        //    add { btnCommentEdit += value; }
        //    remove { btnCommentEdit -= value; }
        //}

        public event RoutedEventHandler btnChangeRate
        {
            add { btnEditRate.Click += value; }
            remove { btnEditRate.Click -= value; }
        }

        public URestaurantOrderHistoryControl()
        {
            InitializeComponent();
        }
    }
}
