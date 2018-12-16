using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();

            Console.WriteLine(add.GetSum(12));
            Console.ReadLine();

            Addition addDec = new Addition();

            Console.WriteLine(add.GetSum(2.5m));
            Console.ReadLine();

            Addition addString = new Addition();

            Console.WriteLine(add.GetSum("3"));
            Console.ReadLine();

        }
    }
}
