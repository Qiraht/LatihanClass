using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Gunakan Ctrl + F5 untuk Debug

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Time objTime = new Time();
            //Test 1
            /*objTime.DisplayCurrentTime();

            objTime.year = 2010;*/
            
            //Test3
            objTime.Year = 2009;
            objTime.Month = 5;
            objTime.Date = 1;
            /*
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            //Test4
            Console.WriteLine("Hour : {0}", objTime.Hour);
            Console.WriteLine("Minute : {0}", objTime.Minute);
            Console.WriteLine("Second : {0}", objTime.Second);*/
        }
    }
}
