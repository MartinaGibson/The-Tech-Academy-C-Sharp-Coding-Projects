using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of Strings//

            Console.WriteLine("Top 4 Boy's Names in 2018");
            Console.WriteLine("Please enter a number to see which baby name fills that rank.");
            String[] boysNames = { "0 is not a rank.", "Liam", "Noah", "Oliver", "Mason" };
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(boysNames[i]));
            Console.ReadLine();



            //Array of Integers//

            Console.WriteLine("How many apples to you need for your apple pie(s)?");
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("That's too many apples!");
            }
            if (n <= 0)
            {
                Console.WriteLine("How can you make apple pie with no apples?");
            }
            else
                Console.WriteLine("I have " + nums[n] + " apples for you to make apple pie(s) with.");
            Console.ReadLine();



            //List of Strings//

            Console.WriteLine("Top 4 girl's names of 2018");
            Console.WriteLine("Please a number to see which name it ranks");
            List<string> girlNames = new List<string>();
            girlNames.Add("Emma");
            girlNames.Add("Olivia");
            girlNames.Add("Ava");
            girlNames.Add("Isabella");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g == 0)
            {
                Console.WriteLine("There is no 0 ranking");
            }
            else
                Console.WriteLine(Convert.ToString(girlNames[g]));
            Console.ReadLine();












        }
    }
}
