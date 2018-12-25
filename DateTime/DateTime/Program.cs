using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Its is currently "+ currentDate);
            Console.WriteLine("Enter a number");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("It will be {0} {1} hours from now.",currentDate.AddHours(input) ,input);            
            Console.ReadLine();
           
        }
    }
}
