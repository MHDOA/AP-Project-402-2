using Microsoft.Win32;
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
    /// Interaction logic for UFoodPageChange.xaml
    /// </summary>
    public partial class UFoodPageChange : UserControl
    { 
        public void TextBoxEnalbler()
        {
            uinfoPrice.txtBox.IsEnabled = true;
            uinfoRate.txtBox.IsEnabled = true;
            uinfoRawMaterial.txtBox.IsEnabled = true;
        }

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

        public event RoutedEventHandler btnCommentClick
        {
            add { btnComment.Click += value; }
            remove { btnComment.Click -= value; }
        }

        public UFoodPageChange()
        {
            DataContext = this;
            InitializeComponent();
            TextBoxEnalbler();
        }

        private void SelectImage(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*jpg";
            ofd.Multiselect = false;

            if(ofd.ShowDialog() == true)
            {
                imgFoodPicture.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new RestaurantChangeMenuControl());
        }
    }
}
