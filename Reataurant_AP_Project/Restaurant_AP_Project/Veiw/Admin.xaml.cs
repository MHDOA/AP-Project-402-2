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
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void RestaurantRegisterationClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
            ContentVeiw.Children.Add(new RegisterRestaurant());
        }


        private void SearchingRestaurantClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
            ContentVeiw.Children.Add(new SearchingRestaurant());
        }

        private void SearchingComplaintsClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void WatchingLastComplaintsansweredClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void AnsweringComplaitsClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void WathcingAllComppaintsClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ChangingRestaurantPasswordClick(object sender, MouseButtonEventArgs e)
        {
            ContentVeiw.Children.Clear();
        }
    }
}
