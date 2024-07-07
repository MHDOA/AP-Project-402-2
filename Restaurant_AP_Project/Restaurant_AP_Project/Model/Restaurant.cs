using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public class Restaurant
    {
        public Restaurant(int id, string name, string userName, string pass, string address, string city, List<string> categories, List<Food> foods, List<Comment> comments, int rate, List<Order> orders, List<Reserve> reserves, bool isReserveService, bool isDlivery, bool isDineIn)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Rate = rate;
            Username = userName;
            Password = pass;

            if(foods != null)
                Menu = foods;
            if(categories != null)
                Categories = categories;
            if (comments != null)
                ListComments = comments;
            if (orders != null)
                ListOrdersHistory = orders;
            if (reserves != null)
                ListReservesHistory = reserves;

            IsReserveService = isReserveService;
            IsDlivery = isDlivery;
            IsDineIn = isDineIn;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<string> Categories { get; set; }
        public List<Food> Menu { get; set; }
        public List<Comment> ListComments { get; set; }
        public double Rate { get; set; }
        public List<Order> ListOrdersHistory { get; set; }
        public List<Reserve> ListReservesHistory { get; set; }
        public bool IsReserveService { get; set; }
        public bool IsDlivery { get; set; }
        public bool IsDineIn { get; set; }

        public string Username { get; set; }
        public string Password {  get; set; }   
    }
}
