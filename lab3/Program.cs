using System;
using MySql.Data.MySqlClient;

namespace lab3
{
    class TourismInformation
    {
        static void Main(string[] args)
        {
            MySqlConnection con = new MySqlConnection(
            "server=127.0.0.1;database=tourismdb;uid=root;pwd=;");

            con.Open();

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Duration (days): ");
            int duration = Convert.ToInt32(Console.ReadLine());


            // Insert tourism information
            string query =
            "INSERT INTO `tourism_destination`" +
            "(Title, Description, Duration, CreatedDate)" +
            " VALUES(@title,@description,@duration,@date)";


            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);


            cmd.ExecuteNonQuery();


            Console.WriteLine("\nTourism Information Saved Successfully");


            con.Close();

            Console.ReadLine();
        }
    }
}