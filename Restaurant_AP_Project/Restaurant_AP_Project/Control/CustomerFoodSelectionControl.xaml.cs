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
    /// Interaction logic for CustomerFoodSelectionControl.xaml
    /// </summary>
    public partial class CustomerFoodSelectionControl : UserControl
    {
        public CustomerFoodSelectionControl()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerOrderingFromRestaurantControl());
        }

        private void btnOrderClick(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerFoodPageControl());
        }

        private void URestaurantFoodItemControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
