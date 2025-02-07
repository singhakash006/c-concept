using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{ //result calling
    internal class InheritedResult
    {
        static void Main(string[] args)
        { Inherited obj = new Inherited();
            obj.Employee("Aakash", 172);
            obj.Display();
            obj.Employee1(120000);

        }
    }
}
