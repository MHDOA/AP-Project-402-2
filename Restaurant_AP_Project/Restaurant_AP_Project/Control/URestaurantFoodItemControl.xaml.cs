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
    /// Interaction logic for URestaurantFoodItemControl.xaml
    /// </summary>
    public partial class URestaurantFoodItemControl : UserControl
    {
        public string FoodNameText
        {
            get { return txtFoodName.Text; }
            set { txtFoodName.Text = value; }
        }

        public float FoodRate
        {
            get { return float.Parse(uinfoRate.BoxText); }
            set { uinfoRate.BoxText = value.ToString("0.00"); }
        }

        public int FoodInventory
        {
            get { return int.Parse(uinfoFoodInventory.BoxText); }
            set { uinfoFoodInventory.BoxText = value.ToString(); }
        }

        public string FoodRawMaterial
        {
            get { return uinfoRawMaterial.BoxText; }
            set { uinfoRawMaterial.BoxText = value.ToString(); }
        }

        public int FoodPrice
        {
            get { return int.Parse(uinfoPrice.BoxText); }
            set { uinfoPrice.BoxText = value.ToString(); }
        }

        public ImageSource FoodPictureAddress
        {
            get { return imgFoodPicture.Source; }
            set { imgFoodPicture.Source = value; }
        }

        public event RoutedEventHandler btnOrderClick
        {
            add { btnOrder.Click += value; }
            remove { btnOrder.Click -= value; }
        }
        public URestaurantFoodItemControl()
        {
            InitializeComponent();
        }
    }
}
