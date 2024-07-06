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
            List<ComplaintControlAnswer> complaints = new List<ComplaintControlAnswer>()
            {
                new ComplaintControlAnswer {UserName = "user456",
    ComplaintTitle = "کیفیت غذای نامناسب",
    Restaurant = "رستوران ب",
    Description = "کیفیت غذا بسیار پایین بود و مزه آن اصلاً خوب نبود.",
    IsAnswered = true,
    Answer = "ما از شنیدن این موضوع بسیار متاسفیم. بازخورد شما با مدیر رستوران در میان گذاشته شده و اقدامات لازم برای بهبود کیفیت غذا انجام خواهد شد."},
                new ComplaintControlAnswer {UserName = "user456",
    ComplaintTitle = "کیفیت غذای نامناسب",
    Restaurant = "رستوران ب",
    Description = "کیفیت غذا بسیار پایین بود و مزه آن اصلاً خوب نبود.",
    IsAnswered = true,
    Answer = ""}
            };
            lstComplaints.Items.Clear();
            foreach(var complaint in complaints)
            {
                lstComplaints.Items.Add(complaint);
            }
        }
    }
}
