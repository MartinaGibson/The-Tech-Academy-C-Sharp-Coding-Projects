using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QCarInsurance.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int NumberOfSpeedTix { get; set; }
        public string Coverage { get; set; }
        
    }
}