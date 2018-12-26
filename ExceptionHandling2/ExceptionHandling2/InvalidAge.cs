using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    public class InvalidAge : Exception
    {
        public InvalidAge()
        {
            Console.WriteLine("User cannot be less then 1");
        }
    }
}
