using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Test
{
    class Data
    {
        public static string[] Questions = new string[3];
        public static string[] Answers = new string[3];
        public static string[] Variant1 = new string[3];
        public static string[] Variant2 = new string[3];
        public static string[] Variant3 = new string[3];
        public static string[] Variant4 = new string[3];

        public static void GetData()
        {
            MessageBox.Show("sa");
            string connectionString = "server=localhost;user=root;database=Testing;password=0000";
            string Sqlexpression = "SELECT * FROM Questions WHERE Id=2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Sqlexpression,connection);

                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
            }
        }








    }
}
