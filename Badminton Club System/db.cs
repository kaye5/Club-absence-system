using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Badminton_Club_System
{
    public static class db
    {
        public static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=vroxine;");
        public static string sql;
        public static MySqlCommand cmd;
        public static void connectDB()
        {
            connection.Open();
        }
        public static void addCMD()
        {
            cmd = new MySqlCommand(sql, connection);
        }
        public static void closeDB()
        {
            connection.Close();
        }
        public static void disposeCmd()
        {
            cmd.Dispose();
        }
    }
}
