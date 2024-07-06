using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    class Complaint
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string UsernameOfComplainer { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string Restaurant { get; set; }
        public string Answer { get; set; }
        public bool IsAnswered { get; set; }
    }
}
