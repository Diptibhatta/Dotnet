//using System;

//namespace lab2
//{
  //  abstract class Payment
    //{
      //  public string customerName;
        //public double amount;


        //public Payment(string name, double amt)
        //{
          //  customerName = name;
            //amount = amt;
        //}


        //public abstract void ProcessPayment();

        //public abstract void DisplayPaymentDetails();
    //}



    //class CreditCard : Payment
    //{
      //  public CreditCard(string name, double amt)
        //    : base(name, amt)
        //{
        //}


        //public override void ProcessPayment()
        //{
          //  Console.WriteLine("Processing payment through Credit Card");
        //}


        //public override void DisplayPaymentDetails()
        //{
          //  Console.WriteLine("Payment Method: Credit Card");
            //Console.WriteLine("Customer Name: " + customerName);
            //Console.WriteLine("Amount: " + amount);
        //}
    //}



    //class DebitCard : Payment
    //{
     //   public DebitCard(string name, double amt)
       //     : base(name, amt)
        //{
        //}


        //public override void ProcessPayment()
        //{
          //  Console.WriteLine("Processing payment through Debit Card");
        //}


        //public override void DisplayPaymentDetails()
        //{
          //  Console.WriteLine("Payment Method: Debit Card");
            //Console.WriteLine("Customer Name: " + customerName);
            //Console.WriteLine("Amount: " + amount);
        //}
    //}



//    class DigitalWallet : Payment
  //  {
    //    public DigitalWallet(string name, double amt)
      //      : base(name, amt)
        //{
        //}


        //public override void ProcessPayment()
        //{
          //  Console.WriteLine("Processing payment through Digital Wallet");
        //}


        //public override void DisplayPaymentDetails()
        //{
          //  Console.WriteLine("Payment Method: Digital Wallet");
            //Console.WriteLine("Customer Name: " + customerName);
            //Console.WriteLine("Amount: " + amount);
        //}
    //}



    //class Program
    //{
      //  static void Main(string[] args)
        //{
          //  Payment p;
          //
          //
            //p = new CreditCard("Ram", 5000);
            //p.DisplayPaymentDetails();
            //p.ProcessPayment();


            //Console.WriteLine();


            //p = new DebitCard("Sita", 3000);
            //p.DisplayPaymentDetails();
            //p.ProcessPayment();


            //Console.WriteLine();


            //p = new DigitalWallet("Hari", 2000);
            //p.DisplayPaymentDetails();
            //p.ProcessPayment();


            //Console.ReadLine();
        //}
    //}
//}