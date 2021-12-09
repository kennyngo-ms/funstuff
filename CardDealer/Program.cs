using System;
using System.Collections.Generic;

namespace CardDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int cardIndex = 0;
            int handsize = 4; //must be less than 13
            int player=0;

            List<int> deck = new List<int>();
            List<int> player1 = new List<int>();
            List<int> player2 = new List<int>();
            List<int> player3 = new List<int>();
            List<int> player4 = new List<int>();

            for (int i = 0; i < 52; i++)
            {
                deck.Add(i);
            }

            //deal card
            for (int i=0; i< handsize*4; i++)
            {
                if (deck.Count >= 1)
                {
                    cardIndex = ran.Next(0, deck.Count);
                    switch ((player+i)%4+1)
                    {
                        case 1: player1.Add(deck[cardIndex]); break;
                        case 2: player2.Add(deck[cardIndex]); break;
                        case 3: player3.Add(deck[cardIndex]); break;
                        case 4: player4.Add(deck[cardIndex]); break;
                        default: break;
                    }

                    //pop card from deck
                    deck.RemoveAt(cardIndex);

                }
                else Console.WriteLine("Deck is empty.");
            }

            Console.WriteLine("Player 1:");
            printCard(player1);
            Console.WriteLine("\nPlayer 2:");
            printCard(player2);
            Console.WriteLine("\nPlayer 3:");
            printCard(player3);
            Console.WriteLine("\nPlayer 4:");
            printCard(player4);

        }

        static void printCard(List<int> player)
        {
            int count = 1;
            player.Sort();
            foreach( int i in player)
            {
                Console.Write(getCard(i)+" \n");
                count++;
            }
        }


        static string getCard(int key)
        {
            int number = key / 4;
            int type = key % 4;
            string numbertype;
            switch (number+1)
            {
                case 1: numbertype= String.Concat(number+1); break;
                case 2: numbertype = String.Concat(number+1); break;
                case 3: numbertype = String.Concat(number+1); break;
                case 4: numbertype = String.Concat(number+1); break;
                case 5: numbertype = String.Concat(number+1); break;
                case 6: numbertype = String.Concat(number+1); break;
                case 7: numbertype = String.Concat(number+1); break;
                case 8: numbertype = String.Concat(number+1); break;
                case 9: numbertype = String.Concat(number+1); break;
                case 10: numbertype = "Jack"; break;
                case 11: numbertype = "Queen"; break;
                case 12: numbertype = "King"; break;
                case 13: numbertype = "Ace"; break;
                default: numbertype = "error"; break;
            }

            switch (type+1){
                case 1: return numbertype + " of Spade";
                case 2: return numbertype + " of Club";
                case 3: return numbertype + " of Diamond";
                case 4: return numbertype + " of Heart";
                default: return numbertype + ":error";
            }
        }
    }
}
