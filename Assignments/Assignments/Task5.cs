using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    
        // Base Class
        public class Vehicle1
        {
            public string Manufacturer; // Properties defined
            public string ModelName;
            public int Year;
            public string Color;

            // Constructor for Vehicle class
            public Vehicle1(string manufacturer, string modelName, int year, string color)
            {
                this.Manufacturer = manufacturer;
                ModelName = modelName;
                Year = year;
                Color = color;
            }

            public virtual void Display()
            {
                Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}");
            }

            // Demonstrate Polymorphism
            public void DisplayInfo(int numDoors)
            {
                Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}, NumDoors : {numDoors}");
            }

            public void DisplayInfo(int numDoors, float length)
            {
                Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}, NumDoors : {numDoors}, Length : {length}m");
            }

            public void DisplayInfo(int numDoors, int batteryCapacity)
            {
                Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}, NumDoors : {numDoors}, BatteryCapacity : {batteryCapacity}kw");
            }
        }

        // Car Class inherits from Vehicle
        public class Car : Vehicle1
        {
            public int NumDoors;

            // Constructor for Car class, calling the base constructor for Vehicle class
            public Car(string manufacturer, string modelName, int year, string color, int numDoors)
                : base(manufacturer, modelName, year, color)  // Calling the Vehicle constructor
            {
                this.NumDoors = numDoors;
            }

            public override void Display()
            {
                Console.WriteLine($"[Modified Car] Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}, NumDoors : {NumDoors}");
            }
        }

        // ElectricCar Class inherits from Car
        public class ElectricCar : Car
        {
            private int BatteryCapacity;

            // Constructor for ElectricCar class, calling the base constructor for Car class
            public ElectricCar(string manufacturer, string modelName, int year, string color, int numDoors, int batteryCapacity)
                : base(manufacturer, modelName, year, color, numDoors)  // Calling the Car constructor
            {
                this.BatteryCapacity = batteryCapacity;
            }

            public override void Display()
            {
                Console.WriteLine($"[Electric Car] Vehicle : {Year} {Manufacturer} {ModelName}, Color : {Color}, NumDoors : {NumDoors}, BatteryCapacity : {BatteryCapacity}kWh");
            }
        }

    // Main class to demonstrate functionality
    internal class Task5
    {

        public static void Main(string[] args)
            {
                // Demonstrate polymorphism and object creation for ElectricCar
                ElectricCar electricCar = new ElectricCar("Toyota", "Corolla", 2020, "Red", 4, 75);

                // Simply display battery capacity of electric car using the Display method
                electricCar.Display();

                // Use DisplayInfo to show polymorphic data including electric car battery capacity
                electricCar.DisplayInfo(4, 75); // Calling DisplayInfo method with numDoors and batteryCapacity
            }
        }
    }



