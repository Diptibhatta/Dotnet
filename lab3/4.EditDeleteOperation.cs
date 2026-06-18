//using System;
//using MySql.Data.MySqlClient;

//namespace lab3
//{
  //  class EditDeleteOperation
   // {
     //   static void Main(string[] args)
       // {
         //   MySqlConnection con = new MySqlConnection(
           // "server=127.0.0.1;database=studentdb;uid=root;pwd=;");

            //con.Open();


            // Update operation
            //string updateQuery =
            //"UPDATE Student SET Name='Sita', Age=22 WHERE Id=1";

            //MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);

            //updateCmd.ExecuteNonQuery();

//            Console.WriteLine("Record Updated Successfully");


            // Delete operation
  //          string deleteQuery =
    //        "DELETE FROM Student WHERE Id=2";

      //      MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
      
      //      deleteCmd.ExecuteNonQuery();

        //    Console.WriteLine("Record Deleted Successfully");


            // Select operation
          //  string selectQuery = "SELECT * FROM Student";

            //MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);

            //MySqlDataReader reader = selectCmd.ExecuteReader();


            //Console.WriteLine("\nStudent Records:");

            //while (reader.Read())
            //{
              //  Console.WriteLine(
                //"ID: " + reader["Id"] +
                //" Name: " + reader["Name"] +
                //" Age: " + reader["Age"]);
            //}


            //reader.Close();
            //con.Close();

            //Console.ReadLine();
        //}
    //}
//}