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
    /// Interaction logic for ComplaintControl.xaml
    /// </summary>
    public partial class ComplaintControl : UserControl
    {
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(ComplaintControl), new PropertyMetadata(string.Empty, OnPropertyChanged));

        public static readonly DependencyProperty RestaurantNameProperty =
            DependencyProperty.Register("RestaurantName", typeof(string), typeof(ComplaintControl), new PropertyMetadata(string.Empty, OnPropertyChanged));

        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime", typeof(DateTime), typeof(ComplaintControl), new PropertyMetadata(DateTime.MinValue, OnPropertyChanged));

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ComplaintControl), new PropertyMetadata(string.Empty, OnPropertyChanged));

        public static readonly DependencyProperty AnsweredProperty =
            DependencyProperty.Register("Answered", typeof(bool), typeof(ComplaintControl), new PropertyMetadata(false, OnPropertyChanged));

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public string RestaurantName
        {
            get { return (string)GetValue(RestaurantNameProperty); }
            set { SetValue(RestaurantNameProperty, value); }
        }

        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public bool Answered
        {
            get { return (bool)GetValue(AnsweredProperty); }
            set { SetValue(AnsweredProperty, value); }
        }

        public ComplaintControl()
        {
            InitializeComponent();
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ComplaintControl;
            control.UpdateBindings();
        }

        private void UpdateBindings()
        {
            if (txtUsername != null)
            {
                txtUsername.Text = Username;
                txtRestaurantName.Text = RestaurantName;
                txtDateTime.Text = DateTime.ToString("yyyy-MM-dd HH:mm:ss");
                txtTitle.Text = Title;
                chkAnswered.IsChecked = Answered;
            }
        }
    }
}
