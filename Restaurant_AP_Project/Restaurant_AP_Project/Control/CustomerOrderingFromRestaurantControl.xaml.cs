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
            if (restaurant.Categories is not null && restaurant.Categories.Count > 0)
            {
                foreach (var item in restaurant.Categories)
                {
                    URestaurantFoodCategory restaurantFoodCategory = new URestaurantFoodCategory();
                    restaurantFoodCategory.CategoryText = item;

                    lstCategory.Items.Add(restaurantFoodCategory);
                }
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

        private void btnBack(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerOrderingFoodControl());
        }

        private void lstMenuSelected(object sender, SelectionChangedEventArgs e)
        {
            string category = ((sender as ListBox).SelectedItem as URestaurantFoodCategory).CategoryText;

            var foods = restaurant.Menu.Where(x => x.Category.Equals(category)).ToList();
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerFoodSelectionControl(foods,restaurant));
        }
    }
}
