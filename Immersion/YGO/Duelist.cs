using System.Collections.Generic;

namespace YGO
{
    public class Duelist
    {
        //nom du joueur
        public string name;
        
        //vie du jouer
        public int hp;
        
        //paquet de carte du joueur
        public List<Card> deck;
        
        //cartes en main du jouer
        public List<Card> hand;

        public Duelist(string _name)
        {
            name = _name;
            hp = 8000;
            deck = new List<Card>();
            hand = new List<Card>();
        }
    }
}