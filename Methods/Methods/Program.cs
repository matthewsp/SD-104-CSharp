using System;

namespace Methods_Random_number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = RandomNumber(1, 100);
            int Input = InputNumber();
            int guesses = 1;
            bool Playagain = true;
            while (Playagain == true)
            {
                while (Input != target)
                {
                    if (Input > target)
                    {
                        Console.WriteLine("That's too high.");
                    }
                    if (Input < target)
                    {
                        Console.WriteLine("That's too low.");
                     }
                    guesses = guesses + 1;
                    Input = InputNumber();
                }
                Console.WriteLine("You win! You made " + guesses + " guesses");
                Console.WriteLine("Would you like to play again? (Enter Y for yes or N for No.)");
                string userInput = Console.ReadLine();
                if(userInput.ToUpper() == "Y")
                {
                    target = RandomNumber(1, 10);
                    Input = InputNumber();
                    guesses = 1;
                    Playagain = true;
                }
                if (userInput.ToUpper() == "N")
                {
                    Console.WriteLine("Goodbye.");
                    Playagain = false;
                }
            }   
        }
        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private static int InputNumber()
        {
            int input;
            Console.Write("Hey you! give me a number! ");
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That's not a valid number.");
            }
            return input;
        }
    }
}
