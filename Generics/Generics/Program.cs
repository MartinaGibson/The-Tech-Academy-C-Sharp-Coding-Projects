using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> EmployeeObj = new Employee<string>();
            EmployeeObj.things = new List<string>() { "Hat", "Pineapple", "Bumbblebee", "Lamp", "Spoon" };

            Employee<int> EmployeeObj2 = new Employee<int>();
            EmployeeObj2.things = new List<int>() { 3, 15, 76, 2, 44 };
                                 
            
                       

            foreach (string thing in EmployeeObj.things)
            {                
                Console.WriteLine(thing);                               
            }
            foreach (int thing2 in EmployeeObj2.things)
            {
                Console.WriteLine(thing2);
            }
            Console.ReadLine();
             
            
            

            
        }
    }
}
