using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_Console_App_3
{
    public class BasicClass
    {
        public int x {get; set;}
        public int y { get; set; }
        public int z { get; set; }
                           
        
        public void DivisionByTwo(int v)
        {
            int result = v / 2;
            Console.WriteLine(v + " divided by 2 equals " + result);
                                  
        }
        public int Addition(int x, int y)
        {            
            return x + y;
                                                     
        }
        public int Addition(int x, int y, int z, out int results)
        {
            return results = x + y + z;
            
        }
            
        
        
        

    }
}
