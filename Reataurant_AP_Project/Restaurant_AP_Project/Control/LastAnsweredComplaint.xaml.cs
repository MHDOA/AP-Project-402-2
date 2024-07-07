using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Data;
using Restaurant_AP_Project.Data;
using Restaurant_AP_Project.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_AP_Project.Control
{
    /// <summary>
    /// Interaction logic for LastAnsweredComplaint.xaml
    /// </summary>
    public partial class LastAnsweredComplaint : UserControl
    {

        public LastAnsweredComplaint()
        {
            InitializeComponent(); loadComplaints();
        }
        public void loadComplaints()
        {



            lstComplaints.Items.Clear();

            foreach (var complaint in StaticData.Complaints)
            {
                var complaintControl = new ComplaintControl();
                complaintControl.Id = complaint.Id;
                complaintControl.UserName = complaint.UserName;
                complaintControl.ComplaintTitle = complaint.Title;
                complaintControl.Restaurant = complaint.RestaurantName;
                complaintControl.Description = complaint.Content;
                complaintControl.IsAnswered = complaint.IsAnswered;
                complaintControl.Answer = complaint.Answer;
                complaintControl.ComplaintDateTime = complaint.DateTime;

                lstComplaints.Items.Add(complaintControl);
            }
        }
    }
}
