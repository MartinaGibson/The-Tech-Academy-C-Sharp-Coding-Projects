using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person
    {
        int Id { get; set; }
        

        public override void SayName()
        {
            Console.WriteLine("My Name is ");
            base.SayName();
        }

    }
}
