using Microsoft.Data.SqlClient;
using Restaurant_AP_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.DataAccess
{
    public class DataBaseUpdater
    {
        private string connectionString;

        public DataBaseUpdater(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void UpdateData()
        {
            UpdateCustomers();
            UpdateAdmins();
            UpdateRestaurants();
            UpdateComments();
            UpdateFoods();
            UpdateComplaints();
            UpdateOrders();
        }

        public void UpdateCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var user in StaticData.Customers)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Customer WHERE Id = {user.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Customer SET Name = '{user.Name}', " +
                                   $"                      LastName = N'{user.LastName}', " +
                                   $"                      Phone = N'{user.Phone}', " +
                                   $"                      Email = N'{user.Email}', " +
                                   $"                      Username = '{user.Username}', " +
                                   $"                      Password = '{user.Password}', " +
                                   $"                      Email = N'{user.Email}', " +
                                   $"                      Address = N'{user.Address}', " +
                                   $"                      Gender = N'{user.Gender}', " +
                                   $"                      Service = N'{user.Service}' " +
                                   $"    WHERE Id = {user.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Customer (Name, LastName, Phone, Email, Address, Gender, Service , Username , Password) " +
                                   $"    VALUES (N'{user.Name}', N'{user.LastName}', N'{user.Phone}', " +
                                   $"            N'{user.Email}', N'{user.Address}', N'{user.Gender}', N'{user.Service}' , '{user.Username}' , '{user.Password}') " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void UpdateAdmins()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var admin in StaticData.Admins)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Admin WHERE Id = {admin.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Admin SET Username = '{admin.Username}', " +
                                   $"                      Password = '{admin.Password}' " +
                                   $"    WHERE Id = {admin.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Admin (Username, Password) " +
                                   $"    VALUES ('{admin.Username}', '{admin.Password}') " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRestaurants()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var restaurant in StaticData.Restaurants)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Restaurant WHERE Id = {restaurant.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Restaurant SET Name = N'{restaurant.Name}', " +
                                   $"                          Username = '{restaurant.Username}', " +
                                   $"                          Password = '{restaurant.Password}', " +
                                   $"                          City = N'{restaurant.City}', " +
                                   $"                          IsReserveService = '{restaurant.IsReserveService}', " +
                                   $"                          IsDineIn = '{restaurant.IsDineIn}', " +
                                   $"                          IsDlivery = '{restaurant.IsDlivery}', " +
                                   $"                          Address = N'{restaurant.Address}', " +
                                   $"                          Rate = {restaurant.Rate} " +
                                   $"    WHERE Id = {restaurant.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Restaurant (Name, Username, Password, City,IsDineIn,IsDlivery, IsReserveService, Address, Rate) " +
                                   $"    VALUES (N'{restaurant.Name}', '{restaurant.Username}', '{restaurant.Password}', " +
                                   $"            N'{restaurant.City}', '{restaurant.IsDineIn}', '{restaurant.IsDlivery}','{restaurant.IsReserveService}', " +
                                   $"            N'{restaurant.Address}', {restaurant.Rate}) " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateComments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var comment in StaticData.Comments)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Comment WHERE Id = {comment.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Comment SET RestaurantId = {comment.RestaurantId}, " +
                                   $"                      UserId = {comment.UserId}, " +
                                   $"                      FoodId = {comment.FoodId}, " +
                                   $"                      Content = N'{comment.Content}', " +
                                   $"                      DateTime = '{comment.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                   $"                      Rate = {comment.Rate}, " +
                                   $"                      Answer = N'{comment.Answer}', " +
                                   $"                      IsEdited = '{(comment.IsEdited ? 1 : 0)}' " +
                                   $"    WHERE Id = {comment.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Comment (RestaurantId, UserId ,FoodId , Content, DateTime, Rate, Answer, IsEdited) " +
                                   $"    VALUES ({comment.RestaurantId}, {comment.UserId}, {comment.FoodId}, N'{comment.Content}', " +
                                   $"            '{comment.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}', {comment.Rate}, " +
                                   $"            N'{comment.Answer}', '{(comment.IsEdited ? 1 : 0)}') " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateFoods()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var food in StaticData.Foods)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Food WHERE Id = {food.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Food SET RestaurantId = {food.RestaurantId}, " +
                                   $"                   Name = N'{food.Name}', " +
                                   $"                   RawMaterial = N'{food.RawMaterial}', " +
                                   $"                   Category = N'{food.Category}', " +
                                   $"                   Price = {food.Price}, " +
                                   $"                   Inventory = {food.Inventory}, " +
                                   $"                   Rate = {food.Rate}, " +
                                   $"                   ImageSource = N'{food.ImageSource}' " +
                                   $"    WHERE Id = {food.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Food (RestaurantId, Name, RawMaterial, Category, Price, Inventory, Rate, ImageSource) " +
                                   $"    VALUES ({food.RestaurantId}, N'{food.Name}', N'{food.RawMaterial}', " +
                                   $"            N'{food.Category}', {food.Price}, {food.Inventory}, {food.Rate}, N'{food.ImageSource}') " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateComplaints()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var complaint in StaticData.Complaints)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Complaint WHERE Id = {complaint.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Complaint SET RestaurantId = {complaint.RestaurantId}, " +
                                   $"                        UserId = {complaint.UserId}, " +
                                   $"                        Title = N'{complaint.Title}', " +
                                   $"                        Content = N'{complaint.Content}', " +
                                   $"                        DateTime = '{complaint.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                   $"                        Answer = N'{complaint.Answer}', " +
                                   $"                        IsAnswered = '{(complaint.IsAnswered ? 1 : 0)}' " +
                                   $"    WHERE Id = {complaint.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Complaint (RestaurantId, UserId, Title, Content, DateTime, Restaurant, Answer, IsAnswered) " +
                                   $"    VALUES ({complaint.RestaurantId}, {complaint.UserId}, " +
                                   $"            N'{complaint.Title}', N'{complaint.Content}', '{complaint.DateTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                   $"            N'{complaint.Answer}', '{(complaint.IsAnswered ? 1 : 0)}') " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var order in StaticData.Orders)
                {
                    string query = $"IF EXISTS (SELECT 1 FROM Order WHERE Id = {order.Id}) " +
                                   $"BEGIN " +
                                   $"    UPDATE Order SET RestaurantId = {order.RestaurantId}, " +
                                   $"                       UserId = {order.UserId}, " +
                                   $"                       CreatedDate = '{order.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                   $"                       Price = {order.Price}, " +
                                   $"                       CommentId = {order.CommentId} " +
                                   $"    WHERE Id = {order.Id} " +
                                   $"END " +
                                   $"ELSE " +
                                   $"BEGIN " +
                                   $"    INSERT INTO Order (RestaurantId, UserId, CreatedDate, Price, CommentId) " +
                                   $"    VALUES ({order.RestaurantId}, {order.UserId}, " +
                                   $"            '{order.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")}', {order.Price}, {order.CommentId}) " +
                                   $"END";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
