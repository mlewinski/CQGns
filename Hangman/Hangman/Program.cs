using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"car", "country", "enigma", "complex", "algorithm", "cat", "dog", "panther", "tiger"};
            char option = '*';
            while (option != 'q')
            {
                string password = words[(new Random().Next() % words.Length)];
                string mask = new String('-', password.Length);
                int wrongAnswers = 0; //failure after 6 wrong answers
                bool guessed = false;
                Console.WriteLine("Guess the password!");
                char letter = '\0';
                while (!guessed && wrongAnswers < 6)
                {
                    Console.WriteLine("Password : {0}", mask);
                    Console.Write("Letter : ");
                    try
                    {
                        letter = Convert.ToChar(Console.ReadLine());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        continue;
                    }
                    if (password.Contains(letter))
                    {
                        Console.WriteLine("Yeah!");
                        for (int i = password.IndexOf(letter); i < password.Length; i++)
                        {
                            if (password[i] == letter)
                            {
                                StringBuilder sb = new StringBuilder(mask);
                                sb[i] = letter;
                                mask = sb.ToString();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Noooo");
                        wrongAnswers++;
                    }
                    if (!mask.Contains('-')) guessed = true;
                }
                Console.WriteLine(guessed ? "Congratulations! You won!" : "You failed!");
                Console.WriteLine("q - quit, c - continue");
                try
                {
                    option = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException)
                {
                    option = 'q';
                }
            }
        }
    }
}
