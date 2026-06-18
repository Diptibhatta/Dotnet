//using System;

//namespace lab2
//{
  //  class ContactBook
    //{
      //  private string[] names = new string[10];
        //private string[] phoneNumbers = new string[10];

        // Indexer to store and retrieve contact details
        //public string this[int index]
        //{
          //  get
            //{
              //  return names[index] + " - " + phoneNumbers[index];
            //}
            //set
            //{
                // value format: "Name,PhoneNumber"
              //  string[] data = value.Split(',');

                //if (data.Length == 2)
                //{
                 //   names[index] = data[0];
                   // phoneNumbers[index] = data[1];
                //}
            //}
        //}

        //public int Length
        //{
          //  get { return names.Length; }
        //}
    //}

    //class Program
    //{
     //   static void Main(string[] args)
      //  {
        //    ContactBook contacts = new ContactBook();

            // Storing contacts
          //  contacts[0] = "Ram Sharma,9800000001";
            //contacts[1] = "Sita Rai,9800000002";
            //contacts[2] = "Hari KC,9800000003";

            //Console.WriteLine("Contact List:\n");

            //for (int i = 0; i < contacts.Length; i++)
            //{
              //  if (contacts[i] != " - ")
                //{
                  //  Console.WriteLine(contacts[i]);
                //}
            //}
        //}
    //}
//}