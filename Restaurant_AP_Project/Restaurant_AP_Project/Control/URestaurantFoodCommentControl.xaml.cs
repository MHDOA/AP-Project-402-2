using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for URestaurantFoodCommentControl.xaml
    /// </summary>
    public partial class URestaurantFoodCommentControl : UserControl
    {
        private string commentAnswer;

        public string CommentAnswer
        {
            get { return commentAnswer; }
            set { commentAnswer = value; }
        }

        public string Comment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }

        public DateTime CreatedDate
        {
            get { return DateTime.Parse(unifoCreatedDate.BoxText); }
            set { unifoCreatedDate.BoxText = value.ToString(); }
        }

        public Visibility btnEditVisibility
        {
            get { return edit.Visibility; }
            set { edit.Visibility = value;
                delete.Visibility = value;
            }
        }

        public Visibility lblEditedVisibility
        {
            get { return lblEdited.Visibility; }
            set { lblEdited.Visibility = value; }
        }

        public double Rate
        {
            set { uinfoRate.BoxText = value.ToString("0.00"); }
        }

        private EventHandler<RoutedEventArgs> btnDeleteClicked;

        public event EventHandler<RoutedEventArgs> btnDeleteClick
        {
            add { btnDeleteClicked = value; }
            remove { btnDeleteClicked = value; }
        }

        private EventHandler<RoutedEventArgs> btnEditClicked;

        public event EventHandler<RoutedEventArgs> btnEditClick
        {
            add { btnEditClicked = value; }
            remove { btnEditClicked = value; }
        }

        private EventHandler<RoutedEventArgs> btnAnswerClicked;

        public event EventHandler<RoutedEventArgs> btnAnswerClick
        {
            add { btnAnswerClicked = value; }
            remove { btnAnswerClicked = value; }
        }

        public URestaurantFoodCommentControl()
        {
            InitializeComponent();
        }

        private void btnAnsewerClicked(object sender, RoutedEventArgs e)
        {
            btnAnswerClicked?.Invoke(this, e);
        }

        private void btnEditComment(object sender, RoutedEventArgs e)
        {
            btnEditClicked?.Invoke(this, e);
        }

        private void btnDeleteComment(object sender, RoutedEventArgs e)
        {
            btnDeleteClicked?.Invoke(this, e);
        }
    }
}
