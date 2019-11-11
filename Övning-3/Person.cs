using System;

namespace Övning_3
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int personAge;
        public string personAdress;
        public string personOccupation;

        public void Introduce()
        {
            Console.Clear();
            Console.WriteLine("{0} är {1} år och bor i {2}. Hen är {3} och heter {4} i efternamn.", 
                firstName, personAge, personAdress, personOccupation, lastName);
        }
    }
}