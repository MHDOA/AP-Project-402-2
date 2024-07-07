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
    /// Interaction logic for SearchingRestaurant.xaml
    /// </summary>
    public partial class SearchingRestaurant : UserControl
    {
        public SearchingRestaurant()
        {
            InitializeComponent();
        }

        private void btnSearchClick(object sender, RoutedEventArgs e)
        {
            List<RestaurantControl> restaurants = new List<RestaurantControl>();
            lstRestaurants.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                var restaurantControl = new RestaurantControl
                {
                    RestaurantName = "رستوران " ,
                    Username = "یوزر" ,
                    ReceptionType = "تایپ",
                    Score = (4.0 + i * 0.1).ToString(),
                    Address = "آدرس",
                    Categories = "کتگوری "
                };
                restaurants.Add(restaurantControl);
            }
            foreach (var restaurant in restaurants)
            {
                lstRestaurants.Items.Add(restaurant);
            }
        }
    }
}
