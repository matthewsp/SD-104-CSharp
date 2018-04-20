using System;

namespace GCD_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int rdr;
            Console.WriteLine("Please enter an integer.");
            while (Int32.TryParse(Console.ReadLine(),out n1) == false)
            {
                Console.WriteLine("That's not an integer fool. Give me an interger.");
            }

            Console.WriteLine("Please enter another integer.");
            while (Int32.TryParse(Console.ReadLine(), out n2) == false)
            {
                Console.WriteLine("That's not an integer fool. Give me an interger.");
            }
            if (n1 >= n2)
            {
                while (n1 % n2 != 0)
                {
                    rdr = n1 % n2;
                    n1 = n2;
                    n2 = rdr;
                }
                rdr = n2;
            }
            else
            {
                while (n2 % n1 != 0)
                {
                    rdr = n2 % n1;
                    n2 = n1;
                    n1 = rdr;
                }
                rdr = n1;
            }
            Console.WriteLine("The Greatest Common Divisor is " + rdr);
            Console.Read();
        }
    }
}
