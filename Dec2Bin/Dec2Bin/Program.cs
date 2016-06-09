using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec2Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary converter");
            char option = '\0';
            long dec = 0;
            while (option != 'q')
            {
                Console.WriteLine("Enter value to convert :");
                try
                {
                    dec = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Default value used : 0");
                    dec = 0;
                }
                Console.WriteLine("Value in binary : ");
                Stack<short> stack = new Stack<short>();
                while (dec != 0)
                {
                    stack.Push((short)(dec%2));
                    dec /= 2;
                }
                while(stack.Count!=0) Console.Write(stack.Pop());
                Console.WriteLine("\n\nq - quit, other - continue");
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
