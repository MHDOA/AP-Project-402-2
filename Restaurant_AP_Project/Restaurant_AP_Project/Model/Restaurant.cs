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
            UserName = userName;
            Pass = pass;

            if(foods != null)
                Foods = foods;
            if(categories != null)
                Categories = categories;
            if (comments != null)
                Comments = comments;
            if (orders != null)
                Orders = orders;
            if (reserves != null)
                Reserves = reserves;

            IsReserveService = isReserveService;
            IsDlivery = isDlivery;
            IsDineIn = isDineIn;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<string> Categories { get; set; }
        public List<Food> Foods { get; set; }
        public List<Comment> Comments { get; set; }
        public int Rate { get; set; }
        public List<Order> Orders { get; set; }
        public List<Reserve> Reserves { get; set; }
        public bool IsReserveService { get; set; }
        public bool IsDlivery { get; set; }
        public bool IsDineIn { get; set; }

        public string UserName { get; set; }
        public string Pass {  get; set; }   
    }
}
