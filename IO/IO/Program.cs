using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\tmmar\Logs\logIO.txt", Convert.ToString(number));
            Console.Write("Your number is ");
            Console.WriteLine(File.ReadAllText(@"C:\Users\tmmar\Logs\logIO.txt"));
            Console.ReadLine();
        }
    }
}
