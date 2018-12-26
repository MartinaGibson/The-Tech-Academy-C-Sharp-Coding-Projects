using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            EVAL:
            Console.WriteLine("How old are you?");
            int today = DateTime.Now.Year;
            
            try
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer <= 0)
                {
                    throw new InvalidAge();
                }
                else
                {
                    int age = today - answer;
                    Console.WriteLine("You were born in " + age);
                }

            }
            catch (InvalidAge)
            {
                goto EVAL;
            }
            catch (FormatException)
            {
                Console.WriteLine("Age ain't nothing but a nunber. Please try again entering in only a number.");
                goto EVAL;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured. Please try again.");
                goto EVAL;
            }
            finally
            {
                Console.ReadLine();
            }
            
            

            
            
            
            
        }
    }
}