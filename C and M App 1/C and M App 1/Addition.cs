using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_M_App_1
{
    class Addition
    {
        public int GetSum(int a)
        {
            return a + a;
        }

        public decimal GetSum(decimal a)
        {
            return Convert.ToInt32(a) + 100;
        }

        public string GetSum(string a)
        {
            int aa = Convert.ToInt32(a) + 10;
            return aa.ToString();       
        }
    }
}
