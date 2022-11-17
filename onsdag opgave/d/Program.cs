using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    internal class Program
    {
     static int countDigit(long n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            return count;
        }

        /* Driver code */
        public static void Main()
        {
            long n = 420691337222;
            Console.WriteLine("Number of"
                              + " digits : " + countDigit(n));
        }
    }
}
