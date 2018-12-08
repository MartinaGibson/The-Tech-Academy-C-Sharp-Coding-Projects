using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();


            Console.WriteLine("Please enter weight of your package");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);

            if (packageWeight > 50)
            {
                Console.WriteLine("Sorry bro! This package too heavy to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
            }
         
            
            Console.WriteLine("Please enter the width of the package. ");
            string width = Console.ReadLine();
            int packageWidth = Convert.ToInt32(width);

            Console.WriteLine("Please enter the height of the package");
            string height = Console.ReadLine();
            int packageHeight = Convert.ToInt32(height);

            Console.WriteLine("Please enter the length of the package");
            string length = Console.ReadLine();
            int packageLength = Convert.ToInt32(length);
            

            int dimSum = packageWidth + packageHeight + packageLength;
            

            if (dimSum > 50)
            {
                Console.WriteLine("Bummer dude! This package too big to be shipped via Package Express");
                Console.ReadLine();
            }

            int result = dimSum * packageWeight / 100;
            decimal quote = Convert.ToDecimal(result);

            Console.WriteLine("Your estimate total for shipping this package is: $" + quote + ".00 Thanks and have a super-duper day!");
            Console.ReadLine();
            
                
            

           


            

           

        
            
        }
    }
}
