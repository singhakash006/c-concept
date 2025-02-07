using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{//child
    internal class Inherited : Inheritance
    {
        int salary;
        internal void Employee1(int salary)
        {
            this.salary = salary;
            Display();
        }
        internal void Display()
        {
            Console.WriteLine($"the salary of employee  is {salary}");
        }
    } 
}
