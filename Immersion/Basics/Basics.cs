using System;

namespace Basics
{
    class Basics 
    {
        public static void HelloWho(string str)
        {
            Console.WriteLine("Hello" + str + "!");
        }

        public static int ABS(int n)
        {
            if (n > 0)
                return n;
            return -1 * n;
        }
        
        public static int Fibonacci(int n)
        {
            int F0 = 0, F1 = 1;
            for (var i = 0; i < n; i++)
            {
                F0 = F1; F1 = F0 + F1;
            }
            return F0;
        }
    }
}