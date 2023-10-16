using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.B_number_closest_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));
        }
        public static int test(int a, int b)
        {
            const int n = 100;
            var val1 = Math.Abs(a - n);
            var val2 = Math.Abs(b - n);

            return val1 == val2 ? 0 : (val1 < val2 ? a : b);

        }
            

    }
}
