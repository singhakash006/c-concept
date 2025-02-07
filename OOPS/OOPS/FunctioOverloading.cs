using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class FunctioOverloading
    {
        void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }



        static void Main(string[] args)
        {
            FunctioOverloading obj = new FunctioOverloading();
            obj.add(1, 2);

        }
    }
}