using System;

namespace HW3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy! This Program will calculate the factorial of whatever integer you give me. Please enter your integer.");
            int input;
            int total;
            string print;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That's not an integer silly. Give me an integer.");
            }
            //for(int i = ??, ?? >  ??, i--)
            total = 1;
            print = input.ToString();
            for (int i = input; i > 1; i--)
            {
                print = (print + " x " + (i - 1));
                total = total * i;
            }
            Console.WriteLine(print);
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
