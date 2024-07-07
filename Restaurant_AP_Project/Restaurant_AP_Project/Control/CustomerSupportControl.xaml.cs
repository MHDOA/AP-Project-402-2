using System;
using System.Collections.Generic;
using Restaurant_AP_Project.Veiw;
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
using Restaurant_AP_Project.Model;

namespace Restaurant_AP_Project.Control
{
    /// <summary>
    /// Interaction logic for CustomerSupportControl.xaml
    /// </summary>
    public partial class CustomerSupportControl : UserControl
    {
        Customer Customer { get; set; } = Veiw.CustomerMainVeiw.Customer;
        private void LoadComplaints()
        {
            lstSupport.Items.Clear();

            if(Customer.Complaints != null && Customer.Complaints.Count > 0)
            {
                foreach (var item in Customer.Complaints)
                {
                    ComplaintControl complaint = new ComplaintControl();
                    complaint.ComplaintTitle = item.Title;
                    complaint.Restaurant = item.RestaurantName;
                    complaint.UserName = item.UserName;
                    complaint.ComplaintDateTime = item.DateTime;
                    complaint.IsAnswered = item.IsAnswered;
                    complaint.Description = item.Content;

                    if(item.Answer != null)
                    {
                        complaint.Answer = item.Answer;
                    }

                    lstSupport.Items.Add(complaint);
                }
            }
        }

        private void DataLoader(object sender, EventArgs e)
        {
            LoadComplaints();
        }

        public CustomerSupportControl()
        {
            InitializeComponent();
            DataContext = this;
            this.Loaded += DataLoader;
        }

        private void btnCreateComplaint(object sender, RoutedEventArgs e)
        {
            if(txtRestaurant.Text != null && txtTitle.Text != null && txtContent.Text != null && txtRestaurant.Text.Trim() != "" && txtTitle.Text.Trim() != "" && txtContent.Text.Trim() != "")
            {
                try
                {
                    Complaint complaint = new Complaint();
                    complaint.Title = txtTitle.Text.Trim();
                    complaint.RestaurantName = txtRestaurant.Text.Trim();
                    complaint.Content = txtContent.Text.Trim();
                    complaint.DateTime = DateTime.Now;
                    complaint.IsAnswered = false;
                    complaint.Answer = null;
                    complaint.UserId = Customer.Id;
                    complaint.RestaurantId = Veiw.CustomerMainVeiw.Restaurants.Find(x => x.Name == txtRestaurant.Text.Trim()).Id;
                    complaint.Id = CreateId(complaint, complaint.RestaurantId);

                    if (Customer.Complaints == null)
                        Customer.Complaints = new List<Complaint>();
                    Customer.Complaints.Add(complaint);
                    LoadComplaints();
                }
                catch(Exception ex) 
                {
                    throw ex;
                    MessageBox.Show("نام رستوران نامعتبر");
                }
                
            }
        }

        private int CreateId(Complaint cmp,int restaurantId)
        {
            string target = Customer.Id.ToString() + restaurantId.ToString() + cmp.DateTime.Hour.ToString();
            int id = int.Parse(target);
            return id;
        }
    }
}
