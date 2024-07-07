using Restaurant_AP_Project.Model;
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
    /// Interaction logic for CustomerOrderingFoodControl.xaml
    /// </summary>
    public partial class CustomerOrderingFoodControl : UserControl
    {
        bool IsDlivery = false, IsDine_In = false;
        int rateFilter = -1;
        string cityFilter = "";

        List<Restaurant> restaurants = new List<Restaurant>();
        List<Restaurant> filteredRestaurants = new List<Restaurant>();

        private void LoadData()
        {
            Comment comment = new Comment(1, 1, "سلام خیلی خوب بود", DateTime.Now, 4, false, null);
            Comment comment2 = new Comment(1, 1, "بدک نبود", DateTime.Now, 4, false, "hello");
            Comment comment3 = new Comment(2, 1, "سلام خیلی خوب بود", DateTime.Now, 3, false, null);
            Comment comment4 = new Comment(2, 1, "سلام خیلی خوب بود", DateTime.Now, 2, false, null);

            Food f1 = new Food(1, "ساندویچ", "نون، گوشت", 4, 3, 45, "فست فود", "/Asset/Humber.jpg", new List<Comment>() { comment, comment2, comment3, comment4 });
            //Food f2 = new Food(1, "سیب", "آب", 2, 15, 10, "میوه", "/Asset/Humber.jpg", null);
            Food f3 = new Food(1, "پیتزا", "سس", 5, 5, 80, "فست فود", "/Asset/Humber.jpg", null);

            Restaurant r1 = new Restaurant(1, "خوشه", "sdf", "sdf", "تهران، خیابان فلسطین", "تهران", new List<string> { "فست فود", "میوه"}, new List<Food> { f1,  f3}, null, 4, null, null, true, false, false);
            Restaurant r2 = new Restaurant(1, "نسیم", "sdf", "sdf", "میدان قدس", "تهران", null, null, null, 4, null, null, true, false, true);
            Restaurant r3 = new Restaurant(1, "گوارا", "sdf", "sdf", "تهران، خیابان فلسطین", "یزد", null, null, null, 4, null, null, true, true, false);
            Restaurant r4 = new Restaurant(1, "گیلا", "sdf", "sdf", "زاینده رود", "اصفهان", null, null, null, 4, null, null, true, true, true);
            Restaurant r5 = new Restaurant(1, "زمزم", "sdf", "sdf", "مسجد جامع", "یزد", null, null, null, 4, null, null, true, false, false);


            restaurants.Add(r1);
            restaurants.Add(r2);
            restaurants.Add(r3);
            restaurants.Add(r4);
            restaurants.Add(r5);

            filteredRestaurants = restaurants;
            LoadRestaurant(restaurants);
        }

        private void LoadRestaurant(List<Restaurant> restaurants)
        {
            lstRestaurant.Items.Clear();

            foreach (var item in restaurants)
            {
                URestaurantPreview restaurantPreview = new URestaurantPreview();
                restaurantPreview.RestaurnatNameText = item.Name;
                restaurantPreview.UinfoAddressBoxText = item.Address;
                restaurantPreview.UinfoDliveryBool = item.IsDlivery;
                restaurantPreview.UinfoDine_InBool = item.IsDineIn;
                restaurantPreview.AverageRate = item.Rate;
                restaurantPreview.btnOrderClick += btnOrderClick;

                lstRestaurant.Items.Add(restaurantPreview);
            }
        }


        // To Update Info Correctly
        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        public CustomerOrderingFoodControl()
        {
            InitializeComponent();
            DataContext = this;
            this.Loaded += Data_Loaded;
        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            var rst = filteredRestaurants.Where(x => x.Name.Contains(txtSearch.Text.Trim())).ToList();
            if (txtSearch.Text.Trim() == "")
                rst = filteredRestaurants;
            LoadRestaurant(rst);
        }

        private void btnFilter(object sender, RoutedEventArgs e)
        {
            filteredRestaurants = restaurants.Where(x => (x.IsDlivery == IsDlivery || !IsDlivery) && (x.IsDineIn == IsDine_In || !IsDine_In)).ToList();

            if(cityFilter != "")
                filteredRestaurants = filteredRestaurants.Where(x => x.City == cityFilter).ToList();

            if(rateFilter != -1)
            {
                filteredRestaurants = filteredRestaurants.Where(x => x.Rate <= rateFilter && x.Rate >= rateFilter - 1).ToList();
            }

            LoadRestaurant(filteredRestaurants);
        }

        private void cmbCitySelectionChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cmbSelected = (sender as ComboBox).SelectedItem as ComboBoxItem;

            if(cmbSelected.Name != "cmbAll")
            {
                cityFilter = cmbSelected.Content.ToString();
            }
            else
            {
                cityFilter = "";
            }
        }

        private void chbUnCheck(object sender, RoutedEventArgs e)
        {
            CheckBox chb = sender as CheckBox;

            if (chb.Tag.ToString() == "0") IsDine_In = false;
            else if (chb.Tag.ToString() == "1") IsDlivery = false;
        }

        private void chbCheck(object sender, RoutedEventArgs e)
        {
            CheckBox chb = sender as CheckBox;

            if (chb.Tag.ToString() == "0") IsDine_In = true;
            else if (chb.Tag.ToString() == "1") IsDlivery = true;
        }

        private void btnOrderClick(object sender, RoutedEventArgs e)
        {
            // Get Main UserControl To Find RestaurantName
            URestaurantPreview ur = (URestaurantPreview)((((sender as Button).Parent as Grid).Parent) as Border).Parent;

            var rst = restaurants.Where(x => x.Name == ur.RestaurnatNameText).First();

            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerOrderingFromRestaurantControl(rst));
        }

        private void rbChecked(object sender, RoutedEventArgs e)
        {
            rateFilter = int.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
