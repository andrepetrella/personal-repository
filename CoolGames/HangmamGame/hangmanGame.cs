using System;
using System.Linq;
using System.Collections.Generic;

namespace hangmangame;

public static class Program
{
    public static void Main()
    {
        Game();
    }

    public static void Game()
    {
        List<string> words = new List<string> { "Revolutionary", "International", "Withcraft", "Connecticut", "Unboxing", "Strawberry", "Helicopter", "Accurate" }; // List of words that can be used in the game
        Random random = new Random();
        string mysterious_word; // One of the words in [words]
        int amt_of_letters; // Amount of letters in the mysyerious word
        bool word_guessed = false;
        mysterious_word = words[random.Next(words.Count)];
        amt_of_letters = mysterious_word.Length;

        int attempts_letters_left = 6;
        int total_attempts = 0;

        char[] progress = new char[amt_of_letters];
        for (int i = 0; i < amt_of_letters; i++)
        {
            progress[i] = '_';
        }
        Console.WriteLine("You have to enter a character in order to guess the secret word.");
        Console.WriteLine("Your secret word has " + amt_of_letters + " lettets.\n");

        while (word_guessed != true)
        {


            for (int i = 0; i < progress.Length; i++)
            {
                if (i != (amt_of_letters - 1))
                {
                    Console.Write(progress[i] + " ");
                }
                else
                {
                    Console.Write(progress[i]);
                }
            }

            Console.Write("\n\nYour guess: ");
            string current_guess = Console.ReadLine();
            bool correct_guess = false;

            if (!string.IsNullOrEmpty(current_guess) && current_guess.Length == 1)
            {
                char guess = char.ToUpper(current_guess[0]);

                if (char.IsLetter(guess))
                {
                    int characters_found = 0;

                    for (int i = 0; i < amt_of_letters; i++)
                    {
                        if ((char.ToUpper(mysterious_word[i])).Equals(guess))
                        {
                            progress[i] = guess;
                            correct_guess = true;
                            characters_found += 1;
                        }
                    }
                    if (correct_guess)
                    {
                        Console.WriteLine("Characters Found: " + characters_found + "\n");
                    }
                    else
                    {
                        Console.WriteLine("You have found 0 characters.");
                        attempts_letters_left -= 1;
                        Console.WriteLine("Chances left: " + attempts_letters_left + "\n");
                    }
                    total_attempts += 1;

                    if (!progress.Contains('_'))
                    {
                        Console.WriteLine("\nYou have won! Congrats!\n");
                        break;
                    }
                    if (attempts_letters_left == 0)
                    {
                        Console.WriteLine("\nYou have lost! What a shame!\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong... try entering a valid character.");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong... try entering a single character.");
            }
        }

        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine("Thank you for playing!\n");
        Console.WriteLine("Secret Word: " + mysterious_word.ToUpper() + "\n\nTotal attempets: " + total_attempts);
    }

}
