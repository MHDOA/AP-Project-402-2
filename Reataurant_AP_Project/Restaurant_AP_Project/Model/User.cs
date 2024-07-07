using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Restaurant_AP_Project.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PostalAddress { get; set; }
        public string Gender { get; set; }
        public string SpecialService { get; set; }
        public List<Order> ListOrdersHistory { get; set; }
        public List<Complaint> ListComplaints { get; set; }
        //public List<Reserve> ListReserve { get; set; }
    }
}
