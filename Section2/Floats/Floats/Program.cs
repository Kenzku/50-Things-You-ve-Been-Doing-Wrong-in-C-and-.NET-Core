using System;

namespace Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = 0f;
            var d = 0d; // double
            var money = 0M; // decimal
            Console.WriteLine(0.3 * 3.0 + 0.1 == 1.0); // false
            Console.WriteLine((0.3 * 3.0 + 0.1).Equals(1.0)); // false
            Console.WriteLine((0.3 * 3.0).ToString()); // false: 0.3 * 3.0 = 0.89999999 in C#
            Console.WriteLine(0.3M * 3.0M + 0.1M == 1.0M); // true
        }
    }
}
