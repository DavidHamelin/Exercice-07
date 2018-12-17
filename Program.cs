using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double ABAuCarre, BC, CA;
            Console.WriteLine("Quelle est la longueur de BC ?");
            BC = double.Parse(Console.ReadLine());
            Console.WriteLine("Quelle est la longueur de CA ?");
            CA = double.Parse(Console.ReadLine());

            ABAuCarre = Math.Pow(BC, 2) + Math.Pow(CA, 2);

            Console.WriteLine($"AB est égal à {Math.Sqrt(ABAuCarre)}");

        }
    }
}
