using System;
using System.Collections.Generic;

namespace YGO
{
    public class Game
    {
        public Duelist Kaiba;
        public Duelist Player;
        
        public Game(string playername)
        {
            Kaiba = new Duelist("Kaiba");
            Player = new Duelist(playername);
        }


        public void Board()
        {
            for (int lign =0; lign < 4; lign++)
                for (int nbcard = 0; nbcard < 5; nbcard++)
                {
                    Console.Write("_________      ");
                    
                }
            
        }
        
        public void Play()
        {
            bool winner = false;
            bool stop = false;

            while (!winner && !stop)
            {
                if (Kaiba.hp < 1)
                {
                    Console.WriteLine("{0} wins ! gg :)", Player.name);
                    winner = true;
                }
                else if (Player.hp < 1)
                {
                    Console.WriteLine("Kaiba wins ! Too bad");
                    winner = true;
                }

                else
                {
                    Console.WriteLine("Press any key to continue. Press q to quit");
                    string answer = Console.ReadLine();

                    if (answer == "q")
                        stop = true;

                    else
                    {
                        Kaiba_Round();
                        Player_Round();
                    }
                    
                }
            }

        }

        
        public void Player_Round()
        {
            Console.Clear();
            Board();
            bool WrongAnswer = true;
            
            while (WrongAnswer)
            {
                Console.WriteLine("Draw Phase");
                Console.WriteLine("Press e to pull a card");
                string answer = Console.ReadLine();

                if (answer == "e")
                    WrongAnswer = false;
            }

            Card NewCard = PullCard(Player);
            
            //dessiner la carte sur la console genre dragon blanc aux yeux bleu
            NewCard.Print();
            WrongAnswer = true;
            
            while (WrongAnswer)
            {
                Console.WriteLine("Standby Phase");
                
            }

        }

        public Card PullCard(Duelist duelist)
        {
            int lenght = duelist.deck.Count;
            int index = new Random().Next(lenght);
            Card card = duelist.deck[index];
            
            duelist.hand.Add(card);
            duelist.deck.RemoveAt(index);

            return card;
        }
        
        
        public void Kaiba_Round()
        {
                     
        }
    }
}