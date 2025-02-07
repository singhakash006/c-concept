using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Collection
    {
        //ArrayList

        public static void Main(string[] args)

        {
            String name = "goa";
            Console.WriteLine(name);
            /*
          
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add(2.89f);
            obj.Add("Aksh");

            foreach (object i in obj)
            {
                Console.WriteLine(i);
            }*/

            //Hashtable obj = new Hashtable();
            SortedList obj = new SortedList();
            obj.Add("s1", 78);
            obj.Add("s2", 75);
            obj.Add("s3", 7);
            //obj.Clear( );
            foreach (DictionaryEntry i in obj)
            {
                Console.WriteLine(i.Key + "," + i.Value);
            }
        }
    }
}
