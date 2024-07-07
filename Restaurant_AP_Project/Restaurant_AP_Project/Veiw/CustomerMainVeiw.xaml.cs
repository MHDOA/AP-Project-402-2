using Restaurant_AP_Project.Control;
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
using System.Windows.Shapes;

namespace Restaurant_AP_Project.Veiw
{
    /// <summary>
    /// Interaction logic for CustomerMainVeiw.xaml
    /// </summary>
    public partial class CustomerMainVeiw : Window
    {
        public CustomerMainVeiw()
        {
            DataContext = this;
            InitializeComponent();
            MenuBox.SelectedItem = ProfileItem;
            ContentVeiw.Children.Clear();
            ContentVeiw.Children.Add(new CustomerProfileControl());
        }

        private void ProfileClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
            ContentVeiw.Children.Add(new CustomerProfileControl());
        }
        private void OrderingFoodClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
            ContentVeiw.Children.Add(new CustomerOrderingFoodControl());

        }

        private void HistoryOrderClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
        }

        private void SupportClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
        }
    }
}
