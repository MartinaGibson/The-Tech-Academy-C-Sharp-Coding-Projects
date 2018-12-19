using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {
        public Employee(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public override void SayName()
        {
            Console.WriteLine("My Name is ");
            base.SayName();
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }


    }
}
