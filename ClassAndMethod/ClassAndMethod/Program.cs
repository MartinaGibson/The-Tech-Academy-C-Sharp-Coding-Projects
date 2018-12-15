using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());

            Math mathAdd = new Math();
            int m = mathAdd.Multiple(input);
            int a = mathAdd.Add(input);
            int s = mathAdd.Subtract(input);
                                             
            Console.WriteLine(input + " multiple by 2 equals " + m);
            Console.WriteLine(input + " added to 10 equals " + a);
            Console.WriteLine(input + " subtracted by 1 equals " + s);
            Console.ReadLine();

    
        
            

            
            



            
            

            
        
            
        }
    }
}

