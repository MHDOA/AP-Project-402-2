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
    /// Interaction logic for URestaurantFoodCategory.xaml
    /// </summary>
    public partial class URestaurantFoodCategory : UserControl
    {
        public string CategoryText
        {
            get { return txtCategory.Text; }
            set { txtCategory.Text = value; }
        }

        public URestaurantFoodCategory()
        {
            InitializeComponent();
        }
    }
}
