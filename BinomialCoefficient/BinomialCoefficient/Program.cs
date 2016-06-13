using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinomialCoefficient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateBinomialCoefficient("a", "b", 3));
            Console.ReadLine();
        }

        public static string CalculateBinomialCoefficient(string symbolX, string symbolY, int n) {
            StringBuilder sb = new StringBuilder();
            BigInteger[] binomials = new BigInteger[n+1];
            int numberOfBinomials;
            if (n%2 == 0) numberOfBinomials = n/2;
            else numberOfBinomials = n/2 + 1;
            for (int i = 0; i <= numberOfBinomials; i++)
            {
                binomials[i] = CalculateBinomial(n, i);
                binomials[n - i] = binomials[i];
            }
            for (int k = 0; k <= n; k++)
            {
                sb.Append((k==0)?"":"+");
                sb.Append(binomials[k]);
                if (k == n) sb.Append("");
                else
                {
                    sb.Append("*(");
                    sb.Append(symbolX);
                    sb.Append("^");
                    sb.Append(n-k);
                    sb.Append(")");
                }
                if (k == 0) sb.Append("");
                else
                {
                    sb.Append("*(");
                    sb.Append(symbolY);
                    sb.Append("^");
                    sb.Append(k);
                    sb.Append(")");
                }
                
            }
            GC.Collect();
            return sb.ToString();
        }

        public static BigInteger CalculateBinomial(int n, int k)
        {

            return (Factorial(n)/(Factorial(k)*Factorial(n - k)));

        }

        public static BigInteger Factorial(int n)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
