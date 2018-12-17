using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_Console_App_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicClass basic = new BasicClass();

            Console.WriteLine("Please enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a another number IF YOU WANT TO.");
            int y;
            int results;
            if(int.TryParse(Console.ReadLine(), out y))
            {
                results = basic.optionalparams(x, y);
            }
            else
            {
                results = basic.optionalparams(x);
            }
            Console.WriteLine(results+" is the sum!");
            Console.ReadLine();

            



        }
    }
}
