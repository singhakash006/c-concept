using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ThreadExample
    {
        public static void display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Process" + i);
                Thread.Sleep(1000 );

            }
        }
        public static void Main(string[] args)
        {
            //single threading
            ThreadStart obj = new ThreadStart(ThreadExample.display);
            Thread thread = new Thread(obj);    
            thread.Start();
            thread.Join();
            Thread t2 = new Thread(obj);    
            t2.Start();
           
        }
    }
}
