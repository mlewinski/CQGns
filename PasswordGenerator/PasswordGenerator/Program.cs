using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Password Generator ==========");
            Console.WriteLine("========== Marek Lewinski ==========");
            Console.WriteLine("Acceptable characters :");
            string acceptableChars = Console.ReadLine();
            Console.WriteLine("Number of passwords :");
            int passwordNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length :");
            int length = Convert.ToInt32(Console.ReadLine());
            StringBuilder charactersBuilder = new StringBuilder(acceptableChars);
            Random random=new Random();
            for (int i = 0; i < passwordNumber; i++)
            {
                StringBuilder password = new StringBuilder();
                for (int j = 0; j < length; j++)
                {
                    password.Append(charactersBuilder[random.Next()%(acceptableChars.Length)]);
                }
                Console.WriteLine(password.ToString());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
