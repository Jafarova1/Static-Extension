using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Helpers
{
   public static class Extensions
    {
        public static int CheckFactorial(this int n, int fact = 1)
        {
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
               
            }return fact;
            

        }
    }
}
