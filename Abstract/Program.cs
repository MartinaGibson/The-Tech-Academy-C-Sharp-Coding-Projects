using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(0111);
            {
                employee.firstName = "Sample";
                employee.lastName = "Student";
                
            }
            Employee employee2 = new Employee(0222);
            {
                employee.firstName = "Tom";
                employee.lastName = "Sawyer";
                
            }
            
            Console.WriteLine(employee == employee2); 
            Console.ReadLine();
                


            
            

            employee.SayName();
            Console.ReadLine();

            
            IQuittable quits = new Employee(0111);
            quits.Quit();
            Console.ReadLine();

        }
    }
}
