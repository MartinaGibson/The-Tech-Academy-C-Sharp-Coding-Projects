using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndCompareConsoleAppExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.) Multiple by 50
            Console.WriteLine("Please enter a number.");
            string input1 = Console.ReadLine();
            long product = Convert.ToInt64(input1) * 50;
            Console.Write(input1 + " multipled by 50 is " + product);
            
            Console.ReadLine();

            //2.) Add to 25
            Console.WriteLine("Please enter in another number.");
            string input2 = Console.ReadLine();
            int sum = Convert.ToInt32(input2) + 25;
            Console.Write(input2 + " added to 25 is " + sum);
            
            Console.ReadLine();

            //3.) Divided by 12.5
            Console.WriteLine("Enter one more number.");
            string input3 = Console.ReadLine();
            double quotient = Convert.ToDouble(input3) / (12.5);
            Console.Write(input3 + " divided by 12.5 is " + quotient);
          
            Console.ReadLine();

            //4.) Compare to 50
            Console.WriteLine("Ok, enter one more number. Last time I promise.");
            string input4 = Console.ReadLine();
            Console.Write("Will this number be greater then 50? ");
            int Fifty = 50;
            bool checkIt = Convert.ToInt16(input4) > Fifty;
            Console.Write(checkIt);

            Console.ReadLine();

            //5.) Remainder of 7
            Console.WriteLine("So I lied. Enter one last number please.");
            string input5 = Console.ReadLine();
            int remainder = Convert.ToInt32(input5) % 7;
            Console.Write("Your remainder after " + input5 + " was divided by 7 is " + remainder);

            Console.ReadLine();



        }
    }
}
