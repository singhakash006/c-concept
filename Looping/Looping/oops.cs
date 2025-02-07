using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Trip
    {
        public int fare;
        public string place;
        void Accept(int fare, string place)
        {
            this.fare = fare;   
            this.place = place; 
        }
        //constructor

        Trip(int fare, string place) 
        { 
            this.fare= fare;
            this.place = place;
            Display();
           
        }
        void Display() {

            Console.WriteLine($"fare is {fare} and place is {place}");
        }
        static void Main(string[] args)
        {
            /* Trip trip1 = new Trip();
             trip1.Accept(500, "Aksh");

             trip1.Display();
            */
            Trip str1 = new Trip(100, "Arun");



        }
    }
}
