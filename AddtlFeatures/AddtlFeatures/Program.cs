using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddtlFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Last Minute Sitters";
            Console.WriteLine("Welcome to {0}! What is the age of your child?", companyName);
            var personAge1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is first name of this child?");
            var personName1 = Console.ReadLine();
            Console.WriteLine("What is the name of the 2nd child?");
            var personName2 = Console.ReadLine();
            Peeps child1 = new Peeps(personAge1);
            Peeps child2 = new Peeps(personName2);

            Console.WriteLine("The first child's age is "+personAge1+ " and again "+ child1.personName);
            Console.WriteLine("Oh that's " + personName1);
            Console.WriteLine("The second child's name is "+child2.personName);
            Console.ReadLine();
            Console.WriteLine("What is " + child2.personName + "age?");
            var personAge2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(child2.personName + " is " + personAge2);
            Console.ReadLine();


            
        }
    }
}
