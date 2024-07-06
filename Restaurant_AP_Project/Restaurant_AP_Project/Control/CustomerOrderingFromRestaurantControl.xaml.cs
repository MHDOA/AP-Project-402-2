using Restaurant_AP_Project.Model;
using Restaurant_AP_Project.Veiw;
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
        Restaurant restaurant;

        private void LoadData()
        {
            txtRestaurantName.Text = restaurant.Name;

            // Load Categories
            foreach (var item in restaurant.Categories)
            {
                URestaurantFoodCategory restaurantFoodCategory = new URestaurantFoodCategory();
                restaurantFoodCategory.CategoryText = item;

                lstCategory.Items.Add(restaurantFoodCategory);
            }

            foreach (var item in restaurant.Comments)
            {
                URestaurantCommentHistory commentHistory = new URestaurantCommentHistory();
                commentHistory.Comment = item.CommentText;

                lstComment.Items.Add(commentHistory);
            }
        }
        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        public CustomerOrderingFromRestaurantControl(Restaurant restaurant)
        {
            this.restaurant = restaurant;
            InitializeComponent();
            DataContext = this;
            this.Loaded += Data_Loaded;
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
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerOrderingFoodControl());
        }

        private void btnComment(object sender, RoutedEventArgs e)
        {

        }

        private void lstMenuSelected(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerFoodSelectionControl());
        }
    }
}
