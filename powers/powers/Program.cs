using System;

namespace powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int PowerOf(int number, int power)
        {
            int total = 1;
            for (int x= 0; x < power; x++)
            {
                total = total * number;
            }
            return total;
        }
    }
}
