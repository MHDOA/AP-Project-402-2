using System;
using System.Collections.Generic;
using Restaurant_AP_Project.Veiw;
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
using Restaurant_AP_Project.Model;

namespace Restaurant_AP_Project.Control
{
    /// <summary>
    /// Interaction logic for CustomerOrderHistoryControl.xaml
    /// </summary>
    public partial class CustomerOrderHistoryControl : UserControl
    {

        Customer Customer { get; set; } = Veiw.CustomerMainVeiw.Customer;

        private void LoadOrders()
        {
            if(Customer != null && Customer.Orders != null && Customer.Orders.Count > 0)
            {
                lstOrders.Items.Clear();

                foreach (var item in Customer.Orders)
                {
                    URestaurantOrderHistoryControl order = new URestaurantOrderHistoryControl();
                    order.RestaurantName = CustomerMainVeiw.Restaurants.Find(x => x.Id == item.RestaurantId).Name;
                    order.Price = item.Price;
                    order.txtSerial.BoxText = item.Id.ToString();
                    order.OrderDate = item.CreatedDate;
                    if(item.Rate != -1)
                        order.txtRate.BoxText = item.Rate.ToString();
                    if(item.Comment != null)
                        order.Comment.Comment = item.Comment.Content;

                    lstOrders.Items.Add(order);
                }
            }
        }
        private void DataLoader(object sender, RoutedEventArgs e)
        {
            LoadOrders();
        }

        public CustomerOrderHistoryControl()
        {
            InitializeComponent();
            DataContext = this;
            this.Loaded += DataLoader;
        }

        private void btn(object sender, RoutedEventArgs e)
        {

        }
    }
}
