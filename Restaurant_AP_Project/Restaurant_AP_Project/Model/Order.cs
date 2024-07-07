using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant_AP_Project.Model
{
    public class Order
    {
        public Order(int restaurantId, int userId, int orderId, DateTime createdDate, int price, Comment comment, int rate)
        {
            RestaurantId = restaurantId;
            UserId = userId;
            Id = orderId;
            CreatedDate = createdDate;
            Price = price;
            Comment = comment;
            Rate = rate;
        }

        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Price {  get; set; }
        public Comment Comment { get; set; }
        public float Rate { get; set; }
    }
}
