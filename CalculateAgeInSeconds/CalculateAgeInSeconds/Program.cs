using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            long ageInYears = 0;
            Console.WriteLine("Age in full years : ");
            ageInYears = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Age in months :{0}", ageInYears*12);
            Console.WriteLine("Age in seconds : {0}", (long)31556926*ageInYears);
            Console.ReadLine();
        }
    }
}
