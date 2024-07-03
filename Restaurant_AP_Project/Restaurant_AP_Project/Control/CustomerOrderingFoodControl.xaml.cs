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
        bool IsDlivery, IsDine_In;
        int rateFilter;
        string cityFilter;

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                scrollViewer.LineUp();
            else
                scrollViewer.LineDown();

            e.Handled = true;
        }

        public CustomerOrderingFoodControl()
        {
            InitializeComponent();
            IsDine_In = true;
            IsDlivery = true;

            int rateFilter = -1;

            cityFilter = "";
        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {

        }

        private void btnFilter(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cityFilter + "City");
            MessageBox.Show(rateFilter + "Rate");
            MessageBox.Show(IsDlivery + "IsDlivery");
            MessageBox.Show(IsDine_In + "IsDine_In");
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

        private void URestaurantPreview_btnOrderClick(object sender, RoutedEventArgs e)
        {

        }

        private void rbChecked(object sender, RoutedEventArgs e)
        {
            rateFilter = int.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
