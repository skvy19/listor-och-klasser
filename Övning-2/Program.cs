using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_2
{
    public class Animal
    {
        public string name;
        public int age;
        public string sound;

        public void Talk()
        {
            Console.WriteLine("My name is {0}, I am {1} years old. I say {2}.", name, age, sound);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Animal();
            cat.name = "Ted";
            cat.age = 3;
            cat.sound = "meow";
            cat.Talk();

            Animal dog = new Animal();
            dog.name = "Jerry";
            dog.age = 2;
            dog.sound = "woof-woof";
            dog.Talk();

        }
    }
}
