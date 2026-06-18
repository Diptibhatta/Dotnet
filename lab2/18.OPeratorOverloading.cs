//using System;

//namespace lab2
//{
  //  class Number
    //{
      //  public int value;

        //public Number(int v)
        //{
          //  value = v;
        //}

        // Unary ++ and --
//        public static Number operator ++(Number n)
  //      {
    //        n.value++;
      //      return n;
        //}

        //public static Number operator --(Number n)
        //{
          //  n.value--;
            //return n;
        //}

        // Binary + - * /
        //public static Number operator +(Number a, Number b)
        //{
          //  return new Number(a.value + b.value);
        //}

        //public static Number operator -(Number a, Number b)
        //{
          //  return new Number(a.value - b.value);
        //}

        //public static Number operator *(Number a, Number b)
        //{
          //  return new Number(a.value * b.value);
        //}

        //public static Number operator /(Number a, Number b)
        //{
          //  return new Number(a.value / b.value);
        //}

        // Relational == and !=
        //public static bool operator ==(Number a, Number b)
        //{
          //  return a.value == b.value;
        //}

//        public static bool operator !=(Number a, Number b)
  //      {
    //        return a.value != b.value;
      //  }

        //public override bool Equals(object obj)
        //{
          //  Number n = (Number)obj;
            //return value == n.value;
        //}

        //public override int GetHashCode()
        //{
         //   return value.GetHashCode();
        //}
    //}

    //class Program
    //{
     //   static void Main()
      //  {
        //    Number a = new Number(10);
          //  Number b = new Number(5);

            //Console.WriteLine("Add: " + (a + b).value);
            //Console.WriteLine("Subtract: " + (a - b).value);
            //Console.WriteLine("Multiply: " + (a * b).value);
            //Console.WriteLine("Divide: " + (a / b).value);

            //a++;
            //Console.WriteLine("After ++ : " + a.value);

            //b--;

            //Console.WriteLine("a == b: " + (a == b));
           // Console.WriteLine("a != b: " + (a != b));
        //}
    //}
//}