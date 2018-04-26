using System;
using System.Collections.Generic;
using System.Text;

namespace WarGame
{
    class Card
    {
        int rank;
        int suit;

        public Card()
        {
            rank = 1;
            suit = 4;
        }
        public Card(int rank, int suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        public override string ToString()
        {
            string text = "";
            switch (this.rank)
            {
                case 1:
                    text = "Ace";
                    break;
                case 2:
                    text = "Two";
                    break;
                case 3:
                    text = "Three";
                    break;
                case 4:
                    text = "Four";
                    break;
                case 5:
                    text = "Five";
                    break;
                case 6:
                    text = "Six";
                    break;
                case 7:
                    text = "Seven";
                    break;
                case 8:
                    text = "Eight";
                    break;
                case 9:
                    text = "Nine";
                    break;
                case 10:
                    text = "Ten";
                    break;
                case 11:
                    text = "Jack";
                    break;
                case 12:
                    text = "Queen";
                    break;
                case 13:
                    text = "King";
                    break;
                default: break;
            }
            switch (this.suit)
            {
                case 1:
                    text += " of hearts";
                    break;
                case 2:
                    text += " of diamonds";
                    break;
                case 3:
                    text += " of clubs";
                    break;
                case 4:
                    text += " of spades";
                    break;
                default: break;
            }

            return text;
        }
        static public bool operator <(Card card1, Card card2)
        {
            if(card1.rank<card2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator >(Card card1, Card card2)
        {
            if (card1.rank > card2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Card card1,Card card2)
        {
            if (card1.rank == card2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Card card1, Card card2)
        {
            if (card1.rank != card2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GreaterThan(Card card)
        { if (this.rank > card.rank)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
        public bool IsEqual(Card card)
        {
            if (this.rank == card.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
