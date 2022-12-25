using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHW
{
    public class PrimeHW
    {
        public static string Prime_HW(int x)
        {

            if (x < 2)
            {
                return "錯誤(數字小於2)";
            }
            if (x == 2)
            {
                return "是質數->".PadLeft(7, ' ') + x;
            }
            if(x%2==0)
            {
                return "不是質數->".PadLeft(5, ' ') + x;
            }

            for (int y = 3; y <= Math.Sqrt(x); y += 2)
            {
                if (x % y == 0)
                {
                    return "不是質數->".PadLeft(5, ' ')+x;
                }
            }
            return  "是質數->".PadLeft(7,' ')+x;



        }
        public static string Prime_Range(int x, int y)
        {
            string result = string.Empty;
            for (int Range= x; Range <= y; Range++)
            {
                result += Prime_HW(Range) + "\n";
            }
            return result;
        }
    }
}
