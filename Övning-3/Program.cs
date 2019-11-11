using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; 

            var person = new Person();

            Console.Write("Vad heter du (ange namn och efternam)?: ");
            input = Console.ReadLine();
            var fullName = input.Split(" ");
            person.firstName = fullName[0];
            person.lastName = fullName[1];

            Console.Write("Hur gammal är du?: ");
            input = Console.ReadLine();
            person.personAge = Convert.ToInt32(input);

            Console.Write("Var bor du?: ");
            input = Console.ReadLine();
            person.personAdress = input;
           
            Console.Write("Vilken sysselsättning har du?: ");
            input = Console.ReadLine();
            person.personOccupation = input;

            person.Introduce();
        }
    }
}
