//using System;

//namespace lab2
//{
  //  class Time
    //{
      //  int hours;
        //int minutes;
        //int seconds;


        // Constructor
        //public Time(int h, int m, int s)
        //{
          //  hours = h;
            //minutes = m;
            //seconds = s;
        //}


        //public Time Add(Time t)
        //{
          //  int totalSeconds =
            //seconds + t.seconds +
            //(minutes + t.minutes) * 60 +
            //(hours + t.hours) * 3600;

            //int h = totalSeconds / 3600;
            //totalSeconds %= 3600;

            //int m = totalSeconds / 60;
            //int s = totalSeconds % 60;

            //return new Time(h, m, s);
        //}


        //public Time Subtract(Time t)
        //{
         //   int total1 = hours * 3600 +
          //               minutes * 60 +
            //             seconds;

            //int total2 = t.hours * 3600 +
              //           t.minutes * 60 +
                //         t.seconds;

            //int diff = total1 - total2;

            //int h = diff / 3600;
            //diff %= 3600;

            //int m = diff / 60;
            //int s = diff % 60;

            //return new Time(h, m, s);
        //}


        //public void Display()
        //{
          //  Console.WriteLine(
            //hours + ":" + minutes + ":" + seconds);
        //}
    //}


    //class Program
    //{
      //  static void Main(string[] args)
        //{
          //  Time t1 = new Time(5, 30, 20);
            //Time t2 = new Time(2, 15, 10);

            //Console.WriteLine("First Time:");
            //t1.Display();

            //Console.WriteLine("Second Time:");
            //t2.Display();


            //Console.WriteLine("Addition:");
            //t1.Add(t2).Display();


            //Console.WriteLine("Subtraction:");
            //t1.Subtract(t2).Display();


            //Console.ReadLine();
      //  }
    //}
//}