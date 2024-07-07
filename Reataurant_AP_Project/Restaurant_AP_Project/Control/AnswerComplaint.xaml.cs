using Restaurant_AP_Project.Data;
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
    /// Interaction logic for AnswerComplaint.xaml
    /// </summary>
    public partial class AnswerComplaint : UserControl
    {
        public AnswerComplaint()
        {
            InitializeComponent();
            FillList();
        }
        public void FillList()
        {
            lstComplaints.Items.Clear();

            // Iterate through the list of complaints in StaticData
            foreach (var complaint in StaticData.Complaints)
            {
                // Create a new instance of the ComplaintControlAnswer
                var complaintControl = new ComplaintControlAnswer();

                // Set the properties of the ComplaintControlAnswer from the complaint object
                complaintControl.Id = complaint.Id;
                complaintControl.UserName = complaint.UserName;
                complaintControl.ComplaintTitle = complaint.Title;
                complaintControl.Restaurant = complaint.RestaurantName;
                complaintControl.Description = complaint.Content;
                complaintControl.IsAnswered = complaint.IsAnswered;
                complaintControl.Answer = complaint.Answer;
                complaintControl.ComplaintDateTime = complaint.DateTime;

                // Add the ComplaintControlAnswer to the list
                lstComplaints.Items.Add(complaintControl);
            }
        }
    }
}
