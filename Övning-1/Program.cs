using System;
using System.Collections.Generic;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List <string>();

            while(animals.Count < 5) {
                Console.Write("Ange namnet på ett djur: ");
                var input = Console.ReadLine();
                animals.Add(input);

            }
            Console.WriteLine("\nDu har angivit dessa namn på djur: ");
            foreach(var n in animals) Console.WriteLine(n);
        }
    }
}
