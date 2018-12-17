using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_Console_App_3
{
    static class Program //Static Class
    {
        static void Main(string[] args)
        {
            BasicClass basicMath = new BasicClass(); //Instantiate Class
            Console.WriteLine("Please enter in a number?");
            int v = Convert.ToInt32(Console.ReadLine());  //User enters number

            basicMath.DivisionByTwo(v); //Call Void Method from Basic Class

            Console.WriteLine(v + " plus 10 equals " + basicMath.Addition(v, 10)); 

            Console.WriteLine(v + " plus 20 plus 30 equals " + basicMath.Addition(v, 20, 30, out v)); //Overloaded Method with Output Parameter

            Console.ReadLine();
            
            

           
            
            
            


            
            
            
            

            

            
            Console.ReadLine();
 
        }
    }
}
