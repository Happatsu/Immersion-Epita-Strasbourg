using System;

namespace Basics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //vous devez appeller vos fonctions ici pour les tester !
            
        }
        
        
        // Partie n° 1
        // affichage de texte
        
        //afficher le message "Hello World !" dans la console.
        
        public static void HelloWorld()
        {
            Console.WriteLine("Hello world !");
        }

        //afficher le message "Hello <name> !" dans la console.
        
        public static void HelloWithName(string name)
        {
            Console.WriteLine("Hello " + name + " !");
        }
        
        
        // Partie n° 2
        // Un petit calcul

        // retourne la somme de a + b.
        
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        
        
        // Partie n° 3
        // Les conditions
        
        // afficher le nom du player ayant le plus grand score.
        // si les deux joueurs ont le même score, afficher dans la console "It's a tie !".
        
        public static void printWinner(string namePlayer1, int scorePlayer1, string namePlayer2, int scorePlayer2)
        {
            if (scorePlayer1>scorePlayer2)
                Console.WriteLine("Winner is " + namePlayer1);
            else if (scorePlayer1<scorePlayer2)
                Console.WriteLine("Winner is " + namePlayer2);
            else
                Console.WriteLine("It's a tie");
        }
        
        
        // Partie n° 4
        // Les boucles
        
        
        // Retourner la valeur de n à la puissance x.
        public static int Power(int n, int x)
        {
            int total = 1;

            for (int i = 1; i <= x; i++)
            {
                total *= n;
            }

            return total;
        }

        
        // Retourner la valeur de la  de n.
        // exemple pour n = 5 : on retourne 120 car 1*2*3*4*5 = 120
        // factorielle de 0 retourne 1.
        
        public static int Facto(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }


        // retourner le nombre d'occurrences du caractère "letter" dans la chaine de caractère "message".
        
        public static int CountThisLetter(string message, char letter)
        {
            int count = 0;
            foreach (var l in message)
            {
                if (l == letter)
                    count++;
            }

            return count;
        }

        
        // partie 5 
        // Un peu de difficulté
        
        // Retourner la valeur de la suite de Fibonacci au rang n.
        // Pour rappel, la suite de Fibonacci est définie comme suit:
        //  F(0) = 0
        //  F(1) = 1
        //  F(n) = F(n-1) + F(n-2)
        

        public static int Fibonacci(int n)
        {
            if (n < 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}