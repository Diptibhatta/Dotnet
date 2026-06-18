//using System;
//using MySql.Data.MySqlClient;

//namespace lab3
//{
  //  class DatabaseOperation
    //{
      //  static void Main(string[] args)
        //{
          //  MySqlConnection con = new MySqlConnection(
//            "server=127.0.0.1;database=studentdb;uid=root;pwd=;");

  //          con.Open();

            // Insert
    //        string insertQuery =
      //      "INSERT INTO student(Name, Age) VALUES('Ram',20)";

        //    MySqlCommand cmd = new MySqlCommand(insertQuery, con);

          //  cmd.ExecuteNonQuery();

            //Console.WriteLine("Record Inserted Successfully");


            // Select
            //string selectQuery = "SELECT * FROM student";

            //MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);

            //MySqlDataReader reader = cmd2.ExecuteReader();

            //Console.WriteLine("\nStudent Records:");

            //while (reader.Read())
            //{
              //  Console.WriteLine(
                //"ID: " + reader["id"] +
                //" Name: " + reader["name"] +
                //" Age: " + reader["age"]);
            //}

            //reader.Close();
            //con.Close();

            //Console.ReadLine();
        //}
    //}
//}