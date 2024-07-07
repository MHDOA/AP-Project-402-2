using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.DataAccess
{
    public class AppInitialization
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\AP-Project-402-2\\Reataurant_AP_Project\\Restaurant_AP_Project\\DB\\rest_DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public static DataBaseUpdater updater = new DataBaseUpdater(connectionString);
        public static DataBaseLoader loader = new DataBaseLoader(connectionString);

        public static void Initialize()
        {
            // Optional: Load initial data or perform other setup tasks
            loader.LoadData();
        }
    }
}
