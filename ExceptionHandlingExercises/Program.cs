using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 2, 4, 6, 8, 10, 12, };
                Console.WriteLine("Please enter a number to divide by.");
                int num = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int solution = number / num;
                    Console.WriteLine(number + " divided by " + num + " equals " + solution);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
