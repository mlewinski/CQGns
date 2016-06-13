using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int maxSize = 20;
            int[] table = new int[maxSize];
            for (int i = 0; i < maxSize; i++) table[i] = rnd.Next()%100;
            PrintTable(table);
            SelectionSort(table);
            PrintTable(table);
            Console.ReadLine();
        }

        public static void PrintTable(int[] table)
        {
            foreach(int element in table) Console.Write(element + " ");
            Console.WriteLine();
        }

        public static void BubbleSort(int[] table)
        {
            int p = -1;
            int n = table.Length;
            for (int i = n - 1 ; i > 0 && p!=1; i--)
            {
                p = 1;
                for (int j = 0; j < i; j++)
                {
                    if (table[j] > table[j + 1])
                    {
                        Swap(ref table[j], ref table[j+1]);
                        p = 0;
                    }
                }
            }
        }

        public static void SelectionSort(int[] table)
        {
            int pmin = 0;
            int n = table.Length;
            int i, j;
            for (j = 0; j < n - 1; j++)
            {
                pmin = j;
                for (i = j + 1; i < n; i++) if (table[i] < table[pmin]) pmin = i;
                Swap(ref table[pmin], ref table[j]);
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }
    }
}
