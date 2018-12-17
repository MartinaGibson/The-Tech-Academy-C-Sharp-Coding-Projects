using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_Console_App_2
{
    public class BasicClass
    {
        public int optionalparams(int x, int y = 0)
        {
            return x + Convert.ToInt32(y);            
        }
         
        public int x { get; set; }
        public int y { get; set; }
    }

}
