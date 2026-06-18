//using System;

//namespace lab2
//{
    // Base Class
   // class Vehicle
  //  {
    //    protected string name;
      //  protected float speed;

        //public Vehicle(string name)
        //{
          //  this.name = name;
        //}

//        public virtual float Move(float distance)
  //      {
    //        return distance * speed;
      //  }

        //public string GetName()
        //{
          //  return name;
        //}

        //public virtual string Describe()
        //{
         //   return "This is a vehicle";
        //}
    //}


    // Derived Class
    //class MotorVehicle : Vehicle
    //{
      //  protected int number_of_wheels;
        //protected float engine_volume;


        //public MotorVehicle(string name) : base(name)
        //{
          //  number_of_wheels = 4;
            //engine_volume = 1000;
        //}

        //public virtual string Honk_Horn()
        //{
          //  return "Motor vehicle horn sound";
        //}

        //public override string Describe()
        //{
          //  return "This is a motor vehicle";
        //}
    //}


    // Truck Class
    //class Truck : MotorVehicle
    //{
      //  private float horsepower;


        //public Truck(string name, float horsepower)
          //  : base(name)
        //{
         //   this.horsepower = horsepower;
        //}


        //public string Honk_Horn()
        //{
         //   return "Truck horn: HOOO HOOO";
        //}


        //public override string Describe()
        //{
          //  return "Truck with horsepower: " + horsepower;
        //}
    //}



    // Car Class
    //class Car : MotorVehicle
    //{
      //  private int num_doors;


        //public Car(string name, int num_doors)
          //  : base(name)
        //{
          //  this.num_doors = num_doors;
        //}


        //public string Honk_Horn()
        //{
          //  return "Car horn: Beep Beep";
        //}


        //public override string Describe()
        //{
         //   return "Car with " + num_doors + " doors";
        //}
    //}



    // Airplane Class
    //class Airplane : Vehicle
    //{
      //  private float wingspan;
        //private int capacity;


        //public Airplane(string name, float wingspan, int capacity)
          //  : base(name)
        //{
         //   this.wingspan = wingspan;
           // this.capacity = capacity;
        //}


        //public void Landing_Gear(bool status)
        //{
          //  if (status)
            //    Console.WriteLine("Landing gear opened");
            //else
              //  Console.WriteLine("Landing gear closed");
        //}


        //public override float Move(float distance)
        //{
         //   speed = 500;
          //  return distance * speed;
        //}


        //public override string Describe()
        //{
          //  return "Airplane with capacity: " + capacity;
        //}
    //}



   // class Program
    //{
     //   static void Main(string[] args)
      //  {
        //    Truck t = new Truck("Volvo Truck", 400);
          //  Car c = new Car("Toyota Car", 4);
            //Airplane a = new Airplane("Boeing", 70, 300);


            //Console.WriteLine(t.GetName());
           // Console.WriteLine(t.Describe());
            //Console.WriteLine(t.Honk_Horn());


            //Console.WriteLine();


//            Console.WriteLine(c.GetName());
  //          Console.WriteLine(c.Describe());
   //         Console.WriteLine(c.Honk_Horn());


     //       Console.WriteLine();


       //     Console.WriteLine(a.GetName());
         //   Console.WriteLine(a.Describe());
          //  a.Landing_Gear(true);
            //Console.WriteLine("Distance covered: " + a.Move(10));
        //}
    //}
//}