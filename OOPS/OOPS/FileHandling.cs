using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace OOPS
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\myfile.txt");


            /*FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
           
            
            
          sw.WriteLine("Welcome to the .Net Framework.");
            sw.Close();
            Console.WriteLine("Successfully Created");*/


/*
            //NOW READ DATA
            FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            StreamReader re = new StreamReader(fs); 
            string data = re.ReadToEnd();
            Console.WriteLine(data);
            Console.WriteLine("Successfully Created");
*/


            //Now APPEND THE TEXT FILE

            StreamWriter somet = File.AppendText(@"C:\myfile.txt");
            somet.WriteLine("Thanku For Learning");
            somet.Close();
        }
    }
}
