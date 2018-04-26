using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    class Deck
    {
        public List<Card> theCards;
        public Deck()
        {
            //Generates the cards
            theCards = new List<Card>();
            for(int s = 1; s <= 4; s++)
            {
                for(int r = 1; r <= 13; r++)
                {
                    Card card = new Card(r, s);
                    theCards.Add(card);
                }
            }
        }
        //shuffles them up
        public void Shuffle()
        {
            for(int n = 0; n < theCards.Count; n++)
            {
                Random random = new Random();
                int randomposition = random.Next(theCards.Count - 1);
                Card tempCard = theCards[n];
                theCards[n] = theCards[randomposition];
                theCards[randomposition] = tempCard;

            }
        }
        public Card Draw()
        {
            Card card = theCards[theCards.Count - 1];
            theCards.RemoveAt(theCards.Count - 1);
            return card;
        }
    }
}
