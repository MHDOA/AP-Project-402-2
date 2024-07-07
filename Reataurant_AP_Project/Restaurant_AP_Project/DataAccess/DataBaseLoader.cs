using Microsoft.Data.SqlClient;
using Restaurant_AP_Project.Data;
using Restaurant_AP_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Primitives;


namespace Restaurant_AP_Project.DataAccess
{
    public class DataBaseLoader
    {

        private string connectionString;

        public DataBaseLoader(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void LoadData()
        {
            LoadOrders();
            LoadComments();
            LoadFoods();
            LoadAdmins();
            LoadRestaurants();
            LoadComplaints();
            LoadCustomers();
        }


        public void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders"; // Including schema dbo and square brackets around Order
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Orders = new List<Order>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = new Order
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RestaurantId = Convert.ToInt32(reader["RestaurantId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        CreatedDate = DateTime.Parse(reader["CreatedDate"].ToString()),
                        Price = Convert.ToDouble(reader["Price"]),
                        CommentId = Convert.ToInt32(reader["CommentId"])
                    };
                    StaticData.Orders.Add(order);
                }
                connection.Close();

            }
        }

        public void LoadComments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Comment";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Comments = new List<Comment>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var comment = new Comment
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RestaurantId = Convert.ToInt32(reader["RestaurantId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        Content = reader["Content"].ToString(),
                        DateTime = DateTime.Parse(reader["DateTime"].ToString()),
                        Rate = Convert.ToDouble(reader["Rate"]),
                        Answer = reader["Answer"].ToString(),
                        IsEdited = Convert.ToBoolean(reader["IsEdited"])
                    };
                    StaticData.Comments.Add(comment);
                }
                connection.Close();

            }
        }


        public void LoadFoods()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Food";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Foods = new List<Food>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var food = new Food
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RestaurantId = Convert.ToInt32(reader["RestaurantId"]),
                        Inventory = Convert.ToInt32(reader["Inventory"]),
                        Name = reader["Name"].ToString(),
                        RawMaterial = reader["RawMaterial"].ToString(),
                        Category = reader["Category"].ToString(),
                        Price = Convert.ToDouble(reader["Price"]),
                        Rate = Convert.ToDouble(reader["Rate"]),
                        ImageSource = reader["ImageSource"].ToString(),
                        ListComments = new List<Comment>()  // Assuming comments will be loaded separately
                    };
                    food.ListComments = StaticData.Comments.Where(c => c.FoodId == food.Id).ToList();
                    StaticData.Foods.Add(food);
                }
                connection.Close();

            }
        }

        public void LoadAdmins()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Admin";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Admins = new List<Admin>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var admin = new Admin
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                    StaticData.Admins.Add(admin);
                }
                connection.Close();

            }
        }

        public void LoadRestaurants()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Restaurant";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Restaurants = new List<Restaurant>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var restaurant = new Restaurant
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        City = reader["City"].ToString(),
                        IsReserveService = Convert.ToBoolean(reader["IsReserveService"]),
                        IsDineIn = Convert.ToBoolean(reader["IsDineIn"]),
                        IsDlivery = Convert.ToBoolean(reader["IsDlivery"]),
                        Address = reader["Address"].ToString(),
                        Rate = Convert.ToDouble(reader["Rate"]),
                        Categories = new List<string>(),  // Assuming categories will be loaded separately
                        Menu = new List<Food>(),  // Assuming menu will be loaded separately
                        ListOrdersHistory = new List<Order>(),  // Assuming orders will be loaded separately
                        ListComments = new List<Comment>(),  // Assuming comments will be loaded separately
                        ListReservesHistory = new List<Reserve>()  // Assuming comments will be loaded separately
                    };
                    string cat = reader["Categories"].ToString();
                    restaurant.Menu = StaticData.Foods.Where(f => f.RestaurantId == restaurant.Id).ToList();
                    restaurant.ListOrdersHistory = StaticData.Orders.Where(o => o.RestaurantId == restaurant.Id).ToList();
                    restaurant.ListComments = StaticData.Comments.Where(c => c.RestaurantId == restaurant.Id).ToList();
                    restaurant.ListReservesHistory = new List<Reserve>();
                    restaurant.Categories = cat.Split(",").ToList();
                    StaticData.Restaurants.Add(restaurant);

                }
                connection.Close();

            }
        }




        public void LoadComplaints()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Complaint";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Complaints = new List<Complaint>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var complaint = new Complaint
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RestaurantId = Convert.ToInt32(reader["RestaurantId"]),
                        UserId = Convert.ToInt32(reader["UserId"]),
                        Title = reader["Title"].ToString(),
                        Content = reader["Content"].ToString(),
                        DateTime = DateTime.Parse(reader["DateTime"].ToString()),
                        Answer = reader["Answer"].ToString(),
                        IsAnswered = Convert.ToBoolean(reader["IsAnswered"])
                    };
                    complaint.RestaurantName = StaticData.Restaurants.ToList().FirstOrDefault(r => r.Id == complaint.RestaurantId).Name.ToString();
                    var customer = StaticData.Customers.FirstOrDefault(c => c.Id == complaint.UserId);
                    if (customer != null)
                    {
                        complaint.UserName = customer.Username;
                    }
                    else
                    {
                        // Handle the case where the customer is not found
                        complaint.UserName = "Unknown";
                    }

                    StaticData.Complaints.Add(complaint);

                }
                connection.Close();

            }
        }


        public void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customer";
                SqlCommand command = new SqlCommand(query, connection);
                StaticData.Customers = new List<Customer>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Address = reader["Address"].ToString(),
                        Gender = (Gender)Enum.Parse(typeof(Gender), reader["Gender"].ToString()),
                        Service = (SpecialService)Enum.Parse(typeof(SpecialService), reader["Service"].ToString())
                    };
                    customer.Complaints = StaticData.Complaints.Where(c => c.UserId == customer.Id).ToList();
                    customer.Orders = StaticData.Orders.Where(o => o.UserId == customer.Id).ToList();
                    customer.Comments = StaticData.Comments.Where(c => c.UserId == customer.Id).ToList();
                    customer.Reserves = new List<Reserve>();
                    StaticData.Customers.Add(customer);
                }
                connection.Close();
            }
            LoadComplaints();
        }

    }
}
