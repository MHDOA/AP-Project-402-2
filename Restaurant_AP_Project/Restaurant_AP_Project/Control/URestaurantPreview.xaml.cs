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
    /// Interaction logic for URestaurantPreview.xaml
    /// </summary>
    public partial class URestaurantPreview : UserControl
    {
        public string RestaurnatNameText
        {
            get { return txtRestaurantName.Text; }
            set { txtRestaurantName.Text = value; }
        }

        public bool UinfoDliveryBool
        {
            get { return UinfoDliveryBool; }
            set { uinfoDlivery.BoxText = (value) ? "دارد" : "ندارد"; }
        }

        public bool UinfoDine_InBool
        {
            get { return UinfoDine_InBool; }
            set { uinfoDine_In.BoxText = (value) ? "دارد" : "ندارد"; }
        }

        public string UinfoAddressBoxText
        {
            get { return uinfoAddress.BoxText;}
            set { uinfoAddress.BoxText = value;}
        }

        public float AverageRate
        {
            get { return AverageRate; }
            set { uinfoRate.BoxText = value.ToString("0.00"); }
        }

        public event RoutedEventHandler btnOrderClick
        {
            add { btnOrder.Click += value; }
            remove { btnOrder.Click -= value; }
        }

        public URestaurantPreview()
        {
            InitializeComponent();
        }
    }
}
