using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()

            
        {
            
           

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            

            Console.WriteLine("What page number?");
            string Page = Console.ReadLine();
            int currentPage = Convert.ToInt32(Page);

            //Test Variable Stored from unput... Console.WriteLine("You are on page " + currentPage);

            Console.WriteLine("Do you need help with anything? Please answer "+'"'+"true "+'"'+ "or "+ '"'+"false"+'"');
            string helpStatus = Console.ReadLine();
            bool help = Convert.ToBoolean(helpStatus);

            //Test Variable Stored from input...Console.WriteLine(help);
              
            
            
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string Exp = Console.ReadLine();
            //Test stored variable from input...Console.WriteLine(Exp);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            //Test Stored Variable from input...Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt16(hours);
            //Test Stored Variable from input...Console.WriteLine(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



     


        }
    }
}
