using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Price { get; set; }
        public int CommentId { get; set; }
        public double Rate { get; set; }
    }
}
