using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the password?");
            string password = Console.ReadLine();
            bool isGuessed = password == "Dogs Rule";

            do
            {
                switch (password)
                {
                    case "Cats Rule":
                        Console.WriteLine("That is not the correct password!");
                        Console.WriteLine("What is the password?");
                        password = Console.ReadLine();
                        break;
                    case "dogs rule":
                        Console.WriteLine("You are close! Try again with the first letters of each word being capitalized.");
                        Console.WriteLine("What is the password?");
                        password = Console.ReadLine();
                        break;
                    case "Abra Kadabra":
                        Console.WriteLine("This is not the correct password!");
                        Console.WriteLine("Please try again!");
                        Console.WriteLine("What is the password?");
                        password = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please try again! This is not correct!");
                        Console.WriteLine("What is the password?");
                        password = Console.ReadLine();
                        break;
                    case "Dogs Rule":
                        Console.WriteLine("This is correct! You may pass!");
                        isGuessed = true;
                        break;

                }
            }

            while (!isGuessed);
            {
                
            }
            Console.ReadLine();

            Console.WriteLine("Are you a boy or a girl?");
            string gender = Console.ReadLine();
            bool allowedGender = gender == "girl";

            while (!allowedGender)
            {
                Console.WriteLine("Boys are not allowed! You cannot enter!");
                break;
            }
            while (allowedGender)
            {
                Console.WriteLine("This is a girl's only club... You may enter!");
                break;
            }

            Console.ReadLine();
        }
    }
}
        
            
        
                
