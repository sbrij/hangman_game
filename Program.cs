using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_game
{
    class Program
    {
        static int remainingAttempts = 7;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");

            string[] wordList = { "Annie", "Talon", "Wukong", "Yassuo", "Nasus", "Neeko", "Ahri", "Morgana", "Lux", "Riven", "Yone" };

            //todo 1
            //randomly choose word from list and assign it to a variable called chosenword

            //Randomly select variable from list of words assign to variable "random"
            Random random = new Random();
            int wordListInt = random.Next(0, wordList.Length);

            string chosenWord = wordList[wordListInt].ToLower();
            Console.WriteLine("The word has {0} characters", chosenWord.Length);

            //Additional variables needed outside for the while loop
            List<string> alreadyGuessedLetters = new List<string>();
            string displayWord = "";

            while (remainingAttempts > 0 && displayWord != chosenWord)
            {
                Console.WriteLine();
                //How many attempts left before you lose the game
                Console.WriteLine("Remaining attempts: {0)", remainingAttempts);

                //todo 2
                // ask the guest to guess letter and assign their answer to a varaible called guess
                /// make "guess" Make lowercase.

                //Make user interact with the game by choosing letter
                Console.WriteLine("Enter a letter: ");
                char[] input = Console.ReadLine().ToCharArray();

                string guess = "";
                if (input.Length > 0)
                {
                    guess = input[0].ToString();
                    guess = guess.ToLower();
                }

                alreadyGuessedLetters.Add(guess);
                //todo 3
                // check if the letter the use guessed (guess) is on of the letter in the chosen word
                displayWord = "";
                if (chosenWord.Contains(guess))
                {
                    Console.WriteLine("The letter {0} is within the word.", guess);

                    displayWord = ProcessDisplayWord(chosenWord, alreadyGuessedLetters, displayWord)
                }
                else
                {
                    Console.WriteLine("The letter {0} is NOT within the word.", guess);
                    displayWord = ProcessDisplayWord(chosenWord, alreadyGuessedLetters, displayWord);
                    remainingAttempts--;
                }
                Console.WriteLine(displayWord);

            }

            ExitGame();
        }

        private static string ProcessDisplayWord(string chosenWord, List<string> alreadyGuessedLetters, string display);
        {
            foreach (var letter in chosenWord
            {
                if (alreadyGuessedLetters.Contains(letter.ToString()))
                {
                    displayWord += letter;
                )
                else
                {
                    displayWord += "*";
                }

            }

            return displayedWord;
        }
        
    

        private static void ExitGame(string theWord)
        {
            if (remainingAttempts == 0)
            {
                Console.WriteLine("You have run out of attempts. You have lost!");
                Console.WriteLine("The word was; {0}", theWord);
            }
            else
            {
                Console.WriteLine("You have won the game!");
            }
        }
    }
}