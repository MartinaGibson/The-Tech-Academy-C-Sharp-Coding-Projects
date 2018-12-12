using System;
using System.Collections.Generic;


namespace IterationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise #1
            Console.WriteLine("What are your top 5 favorite animals? Please press enter after each entry.");
            string[] animals = new string[5];

            for (int a = 0; a < animals.Length; a++)
            {
                animals[a] = Console.ReadLine();
            }

            Console.WriteLine("Your favorite animals are ");

            for (int zoo = 0; zoo < animals.Length; zoo++)
            {
                Console.WriteLine(animals[zoo]);
            }
            Console.ReadLine();
            ////End Exercise #1

            ////Exercise #2 & #3
            int lambchop = 4;
            for (; ; )
            {
                Console.WriteLine("This is the song that never ends!"); //Infinite
                Console.WriteLine("It goes on and on my friends!");      //Loop//
                if (lambchop <= 10)
                {
                    break;
                    Console.WriteLine("Make it stop!");
                }
            }
            Console.ReadLine();
            ////End Exercise #2 & #3

            ////Exercise #4 & #5
            int[] temperatures = { 45, 55, 53, 32, 44, 60, 59, 20, 30, 62, 70 };

            for (int low = 0; low < temperatures.Length; low++)
            {
                if (temperatures[low] < 50)
                {
                    Console.WriteLine("low temperatures:" + temperatures[low]);
                }
            }

            for (int high = 0; high <= temperatures.Length - 1; high++)
            {
                if (temperatures[high] > 45)
                {
                    Console.WriteLine("high temperatures: " + temperatures[high]);
                }
            }
            Console.ReadLine();
            ////End #4 & #5

            //Exercise #6, #7 & #8
            List<string> groceryList = new List<string>();

            groceryList.Add("Bread");
            groceryList.Add("Milk");
            groceryList.Add("Eggs");
            groceryList.Add("Frozen Dinner");
            groceryList.Add("Chicken");
            groceryList.Add("Strawberries");
            groceryList.Add("Deli Meat");
            groceryList.Add("Potatoes");
            groceryList.Add("Cheese");
            groceryList.Add("Cookies");
            groceryList.Add("Ice Cream");
            groceryList.Add("Apples");
            groceryList.Add("Toilet Paper");
            groceryList.Add("Vitamins");
            groceryList.Add("Orange Juice");

            Console.WriteLine("Pick a grocery store item and I will see if its on the list.");
            string f = Console.ReadLine();

            foreach (string food in groceryList)
            {
                if (groceryList.Contains(f))
                {
                    Console.WriteLine(f + " has an index of " + groceryList.IndexOf(f));
                    break;
                }
                else if (f != food)
                {
                    Console.WriteLine("That's not on the list");
                    break;
                }

            }
            Console.ReadLine();
            ////End Exercise #6, #7, & #8

            //Exercise #9 and #10
            List<string> clothesInventory = new List<string>() { "Blue Jeans", "White T-Shirt", "Black Slacks", "Floral Skirt", "Blue Tank Top", "Blue Jeans", "Red Shorts", "White Tank Top", "Floral Skirt", "Purple Tank Top", "White Sweater" };

            Console.WriteLine("Please select an article of clothing.");
            string c = Console.ReadLine();

            for (int index = 0; index < clothesInventory.Count; index++)
            {
                if (clothesInventory[index] == c)
                {
                    Console.WriteLine(c + " is indexed at " + index);

                }
                else
                {
                    Console.WriteLine("I do not have that piece of clothing on my inventory list");
                    break;
                }
            }
            Console.ReadLine();
            //End Exercise #9 & #10

            //Exercise #11

            List<string> rainbow = new List<string> { "Red", "Blue", "Purple", "Yellow", "Orange", "Green", "Pink", "Yellow" };
            List<string> dups = new List<string>();
            List<string> noDup = new List<string>();

            foreach (string color in rainbow)
            {
                if (!noDup.Contains(color))
                    noDup.Add(color);
                else
                    dups.Add(color);
            }
            foreach (string color in dups)
                Console.Write(color);

            Console.ReadLine();
        //End Excerise #11

               
                   
                     
                
                    
                
                
                
               
                

                

            



        
            
            
                
            
            
            
        }
    }
}
