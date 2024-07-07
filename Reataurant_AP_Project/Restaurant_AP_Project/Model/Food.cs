using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public class Food
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string RawMaterial { get; set; }
        public int Inventory {  get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double Rate { get; set; }
        public string ImageSource { get; set; }
        public List<Comment> ListComments { get; set; }
    }
}