using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anonymous Income Comparison Program");
            Console.ReadLine();

            String Person1 = "Person 1 ";
            int p1Hourly = 15;
            int HoursWorked = 40;
            String Person2 = "Person 2 ";
            int p2Hourly = 20;
            
            
            Console.Write(Person1);
            Console.ReadLine();

            Console.Write("Hourly Rate? ");
            Console.ReadLine();
            Console.Write(p1Hourly);
            Console.ReadLine();

            Console.Write("Hours worked per week? ");
            Console.ReadLine();
            Console.Write(HoursWorked);
            Console.ReadLine();
                        
            Console.Write(Person2);
            Console.ReadLine();

            Console.Write("Hourly Rate? ");
            Console.ReadLine();
            Console.Write(p2Hourly);
            Console.ReadLine();

            Console.Write("Hours worked per week? ");
            Console.ReadLine();
            Console.Write(HoursWorked);
            Console.ReadLine();
                        
            Console.Write("Annual salary of " + Person1);
            Console.ReadLine();
            double p1Salary = p1Hourly * HoursWorked * 52;
            Console.Write(p1Salary);
            Console.ReadLine();

            Console.Write("Annual salary of " + Person2);
            Console.ReadLine();
            double p2Salary = p2Hourly * HoursWorked * 52;
            Console.Write(p2Salary);
            Console.ReadLine();

            Console.Write("Does " + Person1 + " make more money than "  + Person2 + "?");
            Console.ReadLine();
            bool whoMakesMore = p1Salary > p2Salary;
            Console.Write(whoMakesMore);
            Console.ReadLine();




        }
    }
}
