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
    public partial class ComplaintControl : UserControl
    {
        public int Id { get; set; }

        public string UserName
        {
            get { return txtUserNameValue.Text; }
            set { txtUserNameValue.Text = value; }
        }

        public string ComplaintTitle
        {
            get { return txtComplaintTitleValue.Text; }
            set { txtComplaintTitleValue.Text = value; }
        }

        public string Restaurant
        {
            get { return txtRestaurantValue.Text; }
            set { txtRestaurantValue.Text = value; }
        }

        public string Description
        {
            get { return txtDescriptionValue.Text; }
            set { txtDescriptionValue.Text = value; }
        }

        private bool _isAnswered;
        public bool IsAnswered
        {
            get { return _isAnswered; }
            set
            {
                _isAnswered = value;
                string answer = _isAnswered ? "برسی شده" : "برسی نشده";
                txtIsAnsweredValue.Text = answer;
            }
        }

        public string Answer
        {
            get { return txtAnswerValue.Text; }
            set { txtAnswerValue.Text = value; }
        }

        public DateTime ComplaintDateTime
        {
            get { return DateTime.Parse(txtDateTimeValue.Text); }
            set { txtDateTimeValue.Text = value.ToString(); }
        }

        private bool isShowingAnswer;

        public ComplaintControl()
        {
            InitializeComponent();
            isShowingAnswer = false;
            txtAnswer.Visibility = Visibility.Collapsed;
            txtAnswerValue.Visibility = Visibility.Collapsed;
        }

        private void btnToggleAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (isShowingAnswer)
            {
                ShowComplaintDetails();
                btnToggleAnswer.Content = "دیدن پاسخ";
                btnToggleAnswer.Background = new SolidColorBrush(Colors.BlueViolet);

            }
            else
            {
                ShowAnswer();
                btnToggleAnswer.Content = "برگشت";
                btnToggleAnswer.Background = new SolidColorBrush(Colors.Pink);
            }

            isShowingAnswer = !isShowingAnswer;
        }

        private void ShowAnswer()
        {
            txtComplaintTitleValue.Visibility = Visibility.Collapsed;
            txtUserNameValue.Visibility = Visibility.Collapsed;
            txtRestaurantValue.Visibility = Visibility.Collapsed;
            txtDescriptionValue.Visibility = Visibility.Collapsed;
            txtIsAnsweredValue.Visibility = Visibility.Collapsed;
            txtDateTimeValue.Visibility = Visibility.Collapsed;

            txtComplaintTitle.Visibility = Visibility.Collapsed;
            txtUserName.Visibility = Visibility.Collapsed;
            txtRestaurant.Visibility = Visibility.Collapsed;
            txtDescription.Visibility = Visibility.Collapsed;
            txtIsAnswered.Visibility = Visibility.Collapsed;
            txtDateTime.Visibility = Visibility.Collapsed;

            txtAnswerValue.Visibility = Visibility.Visible;
            txtAnswer.Visibility = Visibility.Visible;
        }

        private void ShowComplaintDetails()
        {
            txtComplaintTitle.Visibility = Visibility.Visible;
            txtUserName.Visibility = Visibility.Visible;
            txtRestaurant.Visibility = Visibility.Visible;
            txtDescription.Visibility = Visibility.Visible;
            txtIsAnswered.Visibility = Visibility.Visible;
            txtDateTimeValue.Visibility = Visibility.Visible;

            txtComplaintTitleValue.Visibility = Visibility.Visible;
            txtUserNameValue.Visibility = Visibility.Visible;
            txtRestaurantValue.Visibility = Visibility.Visible;
            txtDescriptionValue.Visibility = Visibility.Visible;
            txtIsAnsweredValue.Visibility = Visibility.Visible;
            txtDateTime.Visibility = Visibility.Visible;

            txtAnswerValue.Visibility = Visibility.Collapsed;
            txtAnswer.Visibility = Visibility.Collapsed;
        }
    }
}
