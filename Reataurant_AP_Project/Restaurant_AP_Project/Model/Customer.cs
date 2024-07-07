using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public enum Gender { Male, Female };
    public enum SpecialService { None, Gold, Silver, Bronze };
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public SpecialService Service { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
        public List<Complaint> Complaints { get; set; }
        public List<Reserve> Reserves { get; set; }
        public List<Comment> Comments { get; set; }
    }
}