using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employees
    {
        public Employees(string eFirst, string eLast, int eId)
        {
            this.firstName = eFirst;
            this.lastName = eLast;
            this.id = eId;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName + " ID: #" + id;
        }
    }
}
