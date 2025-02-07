using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    data();
                    Depenentmethod();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);

            }
            finally
            {

            }
        }
        public static void data()
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                throw;

            }
        }

        public static void Depenentmethod()
        {
            try
            {
                Console.WriteLine("This method dependent on first method");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                throw;

            }
        }
    }

    
}
