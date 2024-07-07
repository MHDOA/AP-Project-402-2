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
    /// Interaction logic for SearchingComplaint.xaml
    /// </summary>
    public partial class SearchingComplaint : UserControl
    {
        public SearchingComplaint()
        {
            InitializeComponent();
        }

        private void btnSearchClick(object sender, RoutedEventArgs e)
        {
            // Example data, replace with actual search logic
            var complaints = new List<ComplaintControl>
            {
                new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        Answer = "سللللللللللللللاااااااااااااااممممممممممممممممممممممم",
        ComplaintDateTime = DateTime.Now.AddHours(-1)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-2)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-3)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-4)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-5)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-6)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-7)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-8)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-9)
    },
    new ComplaintControl
    {
        UserName = "این برای تست است",
        ComplaintTitle = "این برای تست است",
        Restaurant = "این برای تست است",
        Description = "تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست",
        IsAnswered = true,
        ComplaintDateTime = DateTime.Now.AddHours(-10)
    },};

            lstComplaints.Items.Clear();
            foreach (var complaint in complaints)
            {
                lstComplaints.Items.Add(complaint);
            }
        }

    }
}
