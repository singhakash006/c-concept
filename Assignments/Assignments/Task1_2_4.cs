using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Task1_2_4
    {

        //Base Class
        public class Vehicle
        {
            public string Manufacturer; //properties defined
            public string ModelName;
            public int Year;
            public string Color;
            private string Make;

            public void Assign(string Manufacturer,string ModelName, int Year, string Color)
            {
                this.Manufacturer = Manufacturer;
                this.ModelName = ModelName;
                this.Year = Year;
                this.Color = Color;
            }

            public virtual void Display()
            {
                Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}");
            }

            // demonstrate Encapsulation constructor Task4
            public void SetMake(string value)
            {
                this.Make = value;
            }

            public string GetMake()
            {
                return Make;
            }
        }


        //Derived class Car
        public class Car : Vehicle //vehicle is inherited here
        {
            private int NumDoors;

            public Car(int NumDoors)
            {
                this.NumDoors = NumDoors;
            }
            public override void Display()
            {
                Console.WriteLine($"[Modified Car] Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}, NumDoors : {NumDoors}");


            }

        }

        // Derived class Motorcycle 
        public class Motorcycle : Vehicle //vehicle is inherited here
        {
            private int NumDoors; //

            public Motorcycle(int NumDoors)
            {
                this.NumDoors = NumDoors;
            }
            public override void Display() //Diplay the result by method calling
            {
                Console.WriteLine($"[Modified Motorcycle] Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}, NumDoors : {NumDoors}");


            }

        }

        public static void Main(string[] args)
        {
            //  assigning value to each attribute define din Base class
            Vehicle result = new Vehicle();
            result.Assign("Toyota", "Corolla", 2020,"Red");
            result.Display();   

            Car result1 = new Car(4);
            result1.Assign("Hyndai", "i20", 2020, "Red");
            result1.Display();

            Motorcycle result2 = new Motorcycle(0);
            result2.Assign("Honda", "Hornet", 2020, "Red");
            result2.Display();



            //Demonstrate Application Task4

            result.SetMake("Maserati"); //The value assigned to encapsulated data

            Console.WriteLine("The Vehicle's Make :" + result.GetMake());
        }
    }
}
