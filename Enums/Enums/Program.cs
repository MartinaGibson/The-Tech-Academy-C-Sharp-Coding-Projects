using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        static void Main(string[] args)
        {
            EVAL: 
            Console.WriteLine("What day is it?");
            
                               
            try
            {
                string _day = Console.ReadLine();
                _day = _day.First().ToString().ToUpper() + _day.Substring(1); //will capitalize, the first letter of user input

                if (Enum.TryParse(_day, out DaysOfTheWeek day))
                {
                    if (DateTime.Now.DayOfWeek.ToString() == day.ToString()) //If the user input matches day of the week it CURRENTLY is...
                    {                       
                        Console.WriteLine("It is " + day.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Today is not " + day.ToString());
                        goto EVAL;
                    }
                }
                else
                {
                    throw new Exception(); //Triggers catch without an exception
                }
                    
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                goto EVAL;
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
            
    }
}
    
