using System;
using System.Collections.Generic;
using System.Linq;
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
        public UserControl CommentAnswer
        {
            set
            {
                grdAnswer.Children.Clear();
                grdAnswer.Children.Add(value);
            }
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
            get { return btnEditComment.Visibility; }
            set { btnEditComment.Visibility = value;
                btnDeleteComment.Visibility = value;
            }
        }

        public Visibility lblEditedVisibility
        {
            get { return lblEdited.Visibility; }
            set { lblEdited.Visibility = value; }
        }

        public event RoutedEventHandler btnEditCommentClick
        {
            add { btnEditComment.Click += value; }
            remove { btnEditComment.Click -= value; }
        }

        public URestaurantFoodCommentControl()
        {
            InitializeComponent();
        }
    }
}
