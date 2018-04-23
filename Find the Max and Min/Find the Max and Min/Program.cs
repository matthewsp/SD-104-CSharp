using System;

namespace Find_the_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            int max;
            int min;
            int input;
            Console.Write("Bonjour! I will take an array of numbers you provide me, and then i will return you the minimum and maximum of those numbers.");
            Console.WriteLine("How many numbers will you be giving me?");
            while (!Int32.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("That's not a number, silly. Please enter a number.");
            }
            Console.Write("Please enter number 1: ");
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("That's not a number silly. Please enter a number.");
            }
            min = input;
            max = input;
            for (int i = 2; i<= amount; i++)
            {
                Console.Write("Please enter number" + i + " : ");
                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("That's not a number silly. Please enter a number.");
                }
               
                if (input > max)
                {
                    max = input;
                }
                if (input < min)
                {
                    min= input;
                }
                
            }
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
            Console.Read();
        
        }
    }
}
