using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGuessingGame
{
    class Program
    {
        static BinaryTree tree;

        static void Main(string[] args)
        {
            startNewGame();
            Console.WriteLine("\nStarting the Game");
            tree.query(); //play one game
            while (playAgain())
            {
                Console.WriteLine();
                tree.query(); //play one game
            }
        }

        static bool playAgain()
        {
            Console.Write("\nPlay Another Game? ");
            char inputCharacter = Console.ReadLine().ElementAt(0);
            inputCharacter = Char.ToLower(inputCharacter);
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                Console.WriteLine("Incorrect input please enter again: ");
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            if (inputCharacter == 'y')
                return true;
            else
                return false;
        }

        static void startNewGame()
        {
            Console.WriteLine("Animal AI\n");
            Console.WriteLine("Enter a question about an animal: ");
            string question = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter a guess if the response is Yes: ");
            string yesGuess = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter a guess if the response is No: ");
            string noGuess = Console.ReadLine();
            tree = new BinaryTree(question, yesGuess, noGuess);
        }
    }
}
