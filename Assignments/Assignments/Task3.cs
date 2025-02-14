using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //Base Class
    public class Vehicle
    {
        public string Manufacturer; //properties defined
        public string ModelName;
        public int Year;
        public string Color;
        private string Make;

        public void Assign(string Manufacturer, string ModelName, int Year, string Color)
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

        //Demonstrate Polymorphism
        public void DisplayInfo(int NumDoors)
        {
            Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}, NumDoors : {NumDoors}");

        }
        public void DisplayInfo(int NumDoors, float length)
        {
            Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}, NumDoors : {NumDoors}, Length : {length}");

        }






        internal class Task3and5
        {



            public static void Main(string[] args)
            {
                //  assigning value to each attribute define din Base class
                Vehicle result = new Vehicle();
                result.Assign("Toyota", "Corolla", 2020, "Red");
                //Appending Extra detail into the Vehicle class

                // result.DisplayInfo(4);
                result.DisplayInfo(4, 6.5f);
                Console.Write("Old result Data ==> ");
                result.Display();





                //Demonstrate Application Task4


            }
        }
    }
}



