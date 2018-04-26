using System;

namespace WarGame
{
    class WarGame
    {
        static void Main(string[] args)
        {
            bool gameover = false;
            int P1Points = 0;
            int P2Points = 0;
            Deck deck = new Deck();
            deck.Shuffle();
            while (gameover == false)
            {
                Card P1Card = deck.Draw();
                Card P2Card = deck.Draw();
                int warpoints = 0;
                Console.WriteLine("Player One plays " + P1Card.ToString());
                Console.WriteLine("Player Two plays " + P2Card.ToString());
              if (P1Card.GreaterThan(P2Card) == true)
                {
                    Console.WriteLine("Player One Wins the round.");
                    P1Points = P1Points + 1 + warpoints;
                    warpoints = 0;
                }
              if (P2Card.GreaterThan(P1Card) == true)
                {
                    Console.WriteLine("Player Two Wins the round.");
                    P2Points = P2Points + 1 + warpoints;
                    warpoints = 0;
                }
              if (P1Card.IsEqual(P2Card))
                {
                    Console.WriteLine("War!");
                    warpoints = warpoints + 2;
                }
                Console.Read();
              if(deck.theCards.Count == 0)
                {
                    gameover = true;
                }
            }
            Console.WriteLine("Player One Scored " + P1Points + "points.");
            Console.WriteLine("Player Two Scored " + P2Points + "points.");
            if (P1Points > P2Points)
            {
                Console.WriteLine("Player One wins!");
            }
            if (P2Points > P1Points)
            {
                Console.WriteLine("Player Two wins!");
            }
            if(P1Points == P2Points)
            {
                Console.WriteLine("It's a tie!");
            }
            Console.Read();
        }
    }
}
