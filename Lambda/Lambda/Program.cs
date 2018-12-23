using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employees> employeeList = new List<Employees>();
            List<Employees> JoeList = new List<Employees>();
            List<Employees> JoeList2 = new List<Employees>();
            

            employeeList.Add(new Employees("Joe", "Dawson", 1));            
            employeeList.Add(new Employees("Britta", "Murphy", 2));
            employeeList.Add(new Employees("Lachlan", "Austin", 3));
            employeeList.Add(new Employees("Rex", "Bartell", 4));
            employeeList.Add(new Employees("Amanda", "Graham", 5));
            employeeList.Add(new Employees("Joe", "Garcia", 6));
            employeeList.Add(new Employees("Emilio", "Martinez", 7));
            employeeList.Add(new Employees("Xaviar", "Nichols", 8));
            employeeList.Add(new Employees("Krista", "Beltran", 9));
            employeeList.Add(new Employees("Ming", "Li", 10));
            employeeList.Add(new Employees("Krishna", "Patel", 11));
            employeeList.Add(new Employees("Alejandro", "Garcia", 12));



            foreach (Employees e in employeeList)
            {
                if (e.firstName == "Joe")
                {
                    JoeList.Add(e);
                    Console.WriteLine(e);

                }
            }

            List<Employees> temp1 = employeeList
                .Where(x => x.firstName == "Joe")
                .ToList();

            Console.WriteLine(temp1);
            Console.WriteLine(temp1.ToString());
            Console.WriteLine(temp1.Where(x => x.firstName == "Joe"));

            List<Employees> temp2 = employeeList
                .Where(x => x.id > 5)
                .ToList();

            Console.WriteLine(temp2);
            Console.WriteLine(temp2.ToString());
                                                         
            Console.ReadLine();












        }
    }
}
