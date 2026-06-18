//using System;

//namespace lab3
//{
// Custom Exception class
//  class InvalidAgeException : Exception
//{
//  public InvalidAgeException(string message)
//    : base(message)
//{

//        }
//  }


//class CustomExceptionDemo
//{
//  static void Main(string[] args)
//{
//  try
//{
//  Console.Write("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age < 18)
//{
//  throw new InvalidAgeException(
//"Age must be 18 or above");
//}

//Console.WriteLine("You are eligible");
//}

//catch (InvalidAgeException ex)
//{
//  Console.WriteLine("Custom Exception: "
//+ ex.Message);
//}

//finally
//{
//  Console.WriteLine("Program completed");
//}

//Console.ReadLine();
//}
//}
//}



