using System;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sportsfans!");
            Console.WriteLine("This program magically calculates a baseball player's batting  average!");
            Console.Write("What's the player's name?: ");
            string PlayerName = Console.ReadLine();

            Console.Write("How many hits?: ");
            double Hits = Int32.Parse(Console.ReadLine());
            Console.Write("How many at bats?: ");
            double AB = Int32.Parse(Console.ReadLine());
            double BattingAverage = Hits / AB;

            Console.WriteLine("Batting average = " + BattingAverage);
            Console.Read();


        }
    }
}
