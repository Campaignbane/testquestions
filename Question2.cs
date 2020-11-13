using System;

namespace quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(30, 0));
            Console.WriteLine(test(-45, 15));
            Console.WriteLine(test(25, 30));
            Console.WriteLine(test(23, 20));

        }

        public static bool test(int x, int y)
        {
            bool v = x == 30 || y == 30;
            return v || (x + y == 30);
        }
    }
}
