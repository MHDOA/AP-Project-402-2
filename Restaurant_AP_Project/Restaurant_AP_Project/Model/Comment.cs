using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Restaurant_AP_Project.Model
{
    public class Comment
    {
        public Comment(int userId, int restaurantId, string commentText, DateTime createdDate, double rate, bool isEdited, string answer)
        {
            UserId = userId;
            RestaurantId = restaurantId;
            Content = commentText;
            DateTime = createdDate;
            Rate = rate;
            IsEdited = isEdited;

            if(answer != null)
                Answer = answer;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId {  get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public double Rate { get; set; }
        public bool IsEdited {  get; set; }
        public string Answer {  get; set; }

    }
}
