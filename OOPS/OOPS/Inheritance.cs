using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{//father
    internal class Inheritance
    {
        string name;
        int empID;


        internal void Employee(string name, int empID)
        {
            this.name = name;   
            this.empID = empID;     

        }
        internal void Display()
        {
            Console.WriteLine($"The name of employee is {name} and employee id is {empID}");
        }
    }
}
