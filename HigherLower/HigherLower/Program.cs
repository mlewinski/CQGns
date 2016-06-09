using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueToGuess;
            char option = '\0';
            Console.WriteLine("Higher/Lower \n Guess the number! (Range 1-1000)");
            while (option != 'q')
            {
                int userGuess = 0;
                valueToGuess=new Random().Next()%10001 +1;
                while (userGuess != valueToGuess)
                {
                    Console.WriteLine("Enter number : ");
                    try
                    {
                        userGuess = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    if(userGuess>valueToGuess) Console.WriteLine("Too big!");
                    else if(userGuess<valueToGuess) Console.WriteLine("Too small!");
                }
                Console.WriteLine("Congratulations!");
                Console.WriteLine("q - quit, other - continue");
                try
                {
                    option = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    option = 'q';
                }
            }
        }
    }
}
