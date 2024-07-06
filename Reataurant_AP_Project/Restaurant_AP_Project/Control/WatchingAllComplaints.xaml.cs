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
    /// Interaction logic for WatchingAllComplaints.xaml
    /// </summary>
    public partial class WatchingAllComplaints : UserControl
    {
        public WatchingAllComplaints()
        {
            InitializeComponent();
            loadRests();
        }
        public void loadRests()
        {
            var complaints = new List<ComplaintControl>
            {
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true,Answer = "شلام این تستهههههههههههههه" },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
                new ComplaintControl { UserName = "این برای تست است", ComplaintTitle = "این برای تست است", Restaurant = "این برای تست است", Description ="تست تست تست تست تستتست تست تست تست تستتست تست تست تست تستتست تست تست تست تست", IsAnswered = true },
            };

            lstComplaints.Items.Clear();
            foreach (var complaint in complaints)
            {
                lstComplaints.Items.Add(complaint);
            }
        }

    }
}
