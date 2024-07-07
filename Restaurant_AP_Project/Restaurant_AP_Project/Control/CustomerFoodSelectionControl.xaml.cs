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
    /// Interaction logic for CustomerFoodSelectionControl.xaml
    /// </summary>
    public partial class CustomerFoodSelectionControl : UserControl
    {
        List<Food> foods = new List<Food>();
        Restaurant restaurant;

        private void LoadFoods()
        {
            foreach (var item in foods)
            {
                URestaurantFoodItemControl foodItem = new URestaurantFoodItemControl();
                foodItem.FoodNameText = item.Name;
                foodItem.FoodPrice = item.Price;
                foodItem.FoodRate = item.Rate;
                foodItem.FoodInventory = item.Inventory;
                foodItem.FoodRawMaterial = item.RawMaterial;
                try
                {
                    foodItem.FoodPictureAddress = (ImageSource)new ImageSourceConverter().ConvertFromString(item.ImageSource);
                }
                catch
                {
                    foodItem.FoodPictureAddress = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../Asset/Element/DefaultPicture.png");
                }
                foodItem.btnOrderClick += btnOrderClick;

                lstFoodItems.Items.Add(foodItem);
            }
        }

        private void DataLoader(object sender, RoutedEventArgs e)
        {
            LoadFoods();
        }

        public CustomerFoodSelectionControl(List<Food> foods, Restaurant restaurant)
        {
            this.foods = foods;
            this.restaurant = restaurant;
            InitializeComponent();
            DataContext = this;
            this.Loaded += DataLoader;
            
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerOrderingFromRestaurantControl(restaurant));
        }

        private void btnOrderClick(object sender, RoutedEventArgs e)
        {
            URestaurantFoodItemControl foodItem = (URestaurantFoodItemControl)(((sender as Button).Parent as Grid).Parent as Border).Parent;

            var food = foods.Where(x => x.Name == foodItem.FoodNameText).First();

            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerFoodPageControl(food, restaurant, foods));
        }

        private void URestaurantFoodItemControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
