using System;

namespace YGO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the duelist world, Seto Kaiba wants to fight against you !");
            
            
            Console.WriteLine("What's your name gamer ?");
            string YourName = Console.ReadLine();
            Game game = new Game(YourName);
            game.Play();

        }
    }
}