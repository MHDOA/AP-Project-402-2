using Restaurant_AP_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Data
{
    internal class StaticData
    {

            public static List<Customer> Customers { get; set; } = new List<Customer>();
            public static List<Admin> Admins { get; set; } = new List<Admin>();
            public static List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
            public static List<Comment> Comments { get; set; } = new List<Comment>();
            public static List<Food> Foods { get; set; } = new List<Food>();
            public static List<Complaint> Complaints { get; set; } = new List<Complaint>();
            public static List<Order> Orders { get; set; } = new List<Order>();

            public static Customer customer = new Customer();
            public static Restaurant restaurant = new Restaurant();
            public static Admin admin = new Admin();

    }
}
