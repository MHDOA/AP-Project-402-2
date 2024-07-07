﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public int FoodId { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public double Rate { get; set; }
        public string Answer { get; set; }
        public bool IsEdited { get; set; }
    }
}
