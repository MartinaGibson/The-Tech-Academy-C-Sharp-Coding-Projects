using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddtlFeatures
{
    class Peeps
    {
        public Peeps()
        {

        }
        public Peeps (string personName)
        {
            this.personName = personName;
        }
        public Peeps(int personAge) : this("Who is this? I didn't here the name!")
        {
            
        }     
           

        public string personName{ get; set; }
        public int personAge { get; set; }    
        

        
        
    }
}
