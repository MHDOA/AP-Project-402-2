using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Restaurant_AP_Project.Model
{
    public class Food
    {
        public Food(int restaurantId, string name, string rawMaterial, int rate, int inventory, int price, string category, string imageAddress, List<Comment> comments)
        {
            RestaurantId = restaurantId;
            Name = name;
            RawMaterial = rawMaterial;
            Rate = rate;
            Inventory = inventory;
            Price = price;
            Category = category;
            ImageSource = imageAddress;

            if(comments != null)
                ListComments = comments;
        }

        public int RestaurantId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string RawMaterial {  get; set; }
        public int Rate {  get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string ImageSource { get; set; }

        public int FoodId { get; set; }

        public List<Comment> ListComments { get; set; }
    }
}
