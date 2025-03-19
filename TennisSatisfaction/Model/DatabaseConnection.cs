using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TennisSatisfaction.Model
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=localhost;port=3306;user=root;password=aline;database=tennis";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

