using System;

namespace Assignments
{

    public class Program
    {
        public static void Main()
        {
            string name;
            int age, i = 1;
            double sub1, sub2, sub3;
            string Grade;
            string conti="Y";
            double TotalMarks;
            //Console.WriteLine("Do You Want to Continue : Type Yes(Y) or No(N)");
            //conti = Console.ReadLine();
            while (conti == "Y" || i<=3)
            {
               
                Console.WriteLine($"{i} student -> Enter Your Name");
                name = Console.ReadLine();
                Console.WriteLine($"{i} student -> Enter Your Age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i} student -> Enter Your marks in Math");
                sub1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i} student -> Enter Your marks in Science");
                sub2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i} student -> Enter Your marks in English");
                sub3 = double.Parse(Console.ReadLine());
                TotalMarks = sub1 + sub2 + sub3;
                if (TotalMarks >= 90)
                {
                    // Console.WriteLine("A+ Grade");
                    Grade = "A+";
                }
                else if (TotalMarks < 90 && TotalMarks >= 75)
                {
                    //Console.WriteLine("A Grade");
                    Grade = "A";
                }
                else if (TotalMarks < 75 && TotalMarks >= 60)
                {
                    //Console.WriteLine("B Grade");
                    Grade = "B";
                }
                else if (TotalMarks < 60 && TotalMarks >= 45)
                {
                    // Console.WriteLine("C Grade");
                    Grade = "C";
                }
                else
                {
                    //Console.WriteLine("You are Fail");
                    Grade = "Fail";
                }
                switch (Grade)
                {
                    case "A+":
                        Console.WriteLine("Excellent Job! for Grade A+");
                        break;
                    case "A":
                        Console.WriteLine("Great Work for Grade A+");
                        break;
                    case "B":
                        Console.WriteLine("Good effort for Grade B");
                        break;
                    case "C":
                        Console.WriteLine("You need to work harder! for Grade C");
                        break;
                    default:
                        Console.WriteLine("Try harder for next time! for grade FAil");
                        break;
                }
                i++;
                if (i >= 4)
                {
                    Console.WriteLine("Do You Want to Continue : Type Yes(Y) or No(N)");
                    conti = Console.ReadLine();
                }
               



            }
            Console.WriteLine($"There are {i} student result is displayed");
        }
    }
}

/*
   public class specify : Vehicle
   {
       public void Assign2(string Color)
       {
           this.Color = Color; 
       }

       public void Display()
       {
           Console.WriteLine($"Vehicle : {Year} {Manufacturer} {ModelName} , Color : {Color}");
       }
   }
   */
