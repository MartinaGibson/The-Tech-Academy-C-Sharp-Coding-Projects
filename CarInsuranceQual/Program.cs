using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Academy Car Insurance");
            Console.ReadLine();
           
            Console.WriteLine("What is your age");
            string age = Console.ReadLine();
            
            Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
            string DUI = Console.ReadLine();
            
            Console.WriteLine("How many speeding tickets do you have?");
            string speedTix = Console.ReadLine();
            

            Console.Write("Qualified?");
            Console.ReadLine();
            bool qualified = Convert.ToInt16(age) >= 15 && Convert.ToBoolean(DUI) == false && Convert.ToInt16(speedTix) <= 3;
            Console.Write(qualified);
            Console.ReadLine();

        }
    }
}
