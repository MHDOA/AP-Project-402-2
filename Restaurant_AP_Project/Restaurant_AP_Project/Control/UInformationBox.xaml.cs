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
    /// Interaction logic for UInformationBox.xaml
    /// </summary>
    public partial class UInformationBox : UserControl
    {

        private int maxLength;
        public int Max_Length
        {
            get { return maxLength; }
            set { maxLength = value; }
        }

        private string blockText;
        public string BlockText
        {
            get { return blockText; }
            set { blockText = ":" + value ; }
        }

        private string boxText;
        public string BoxText
        {
            get { return boxText; }
            set { boxText = value; }
        }

        public UInformationBox()
        {
            maxLength = 25;
            InitializeComponent();
            DataContext = this;
        }
    }
}
