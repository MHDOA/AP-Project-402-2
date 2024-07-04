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
    /// Interaction logic for CustomerOrderingFromRestaurantControl.xaml
    /// </summary>
    public partial class CustomerOrderingFromRestaurantControl : UserControl
    {
        public CustomerOrderingFromRestaurantControl()
        {
            InitializeComponent();
        }

        private void btnChangeRate(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (uinfoRate.txtBox.IsEnabled)
            {
                uinfoRate.txtBox.IsEnabled = false;
                button.Content = "ویرایش";
            }
            else
            {
                uinfoRate.txtBox.IsEnabled = true;
                button.Content = "تایید";
            }
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {

        }

        private void btnComment(object sender, RoutedEventArgs e)
        {

        }

        private void lstMenuSelected(object sender, RoutedEventArgs e)
        {
        }
    }
}
