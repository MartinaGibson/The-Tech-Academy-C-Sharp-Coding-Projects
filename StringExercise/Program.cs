using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Martina";
            string color = "green";
            string pet = "dog";
            string petName = "Buddy";

            name = name.ToUpper();
            petName = petName.ToUpper();


            Console.WriteLine("Hello! My name is " + name + ". My favorite color is " + color + ". I also have a " + pet + " named " + petName + ".");
            Console.ReadLine();

            StringBuilder life = new StringBuilder();

            life.Append("\t My name is Martina Gibson. ");
            life.Append("I was born and raised in Colorado. ");
            life.Append("I got married in May 2018. ");
            life.Append("I also have two dogs name Buddy and Toby. ");
            life.Append("Buddy is my first born furbaby. ");
            life.Append("Toby is my wild child furbaby. ");
            life.Append("I am lucky to have such a wonderful life!");

            Console.WriteLine(life);
            Console.ReadLine();



        }
    }
}
