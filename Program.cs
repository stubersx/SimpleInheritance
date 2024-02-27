using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";
        }

        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // derived class of Animal 
    class Bird : Animal
    {
        public string birdName;
        public double age;
        public double length;

        public Bird()
            :base()
        {
            birdName = "";
            age = 0;
            length = 0;
        }

        public Bird(string name, string birdName, double age, double length)
            :base(name)
        {
            this.birdName = birdName;
            this.age = age;
            this.length = length;
        }

        public void displayBird()
        {
            Console.WriteLine($"\nI am {birdName}, my name is {name}!\nI am {age} years old.\nI am {length} cm!!\n");
        }
    }

    class Fox : Animal
    {
        public string region;
        public double age;
        public double weight;

        public Fox()
            :base()
        {
            region = "";
            age = 0;
            weight = 0;
        }

        public Fox(string name, string region, double age, double weight)
            :base(name)
        {
            this.region = region;
            this.age = age;
            this.weight = weight;
        }

        public void displayFox()
        {
            Console.WriteLine($"\nI am a fox, my name is {name}!\nI am from {region}.\nI am {age} years old!!\nI am {weight} kg.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Bird bird1 = new Bird();
            bird1.name = "Lily";
            bird1.birdName = "Kookaburra";
            bird1.age = 1.5;
            bird1.length = 31.8;
            bird1.displayBird();

            //derived class object using parameterized constructor
            Bird bird2 = new Bird("Rose", "Belted Kingfisher", 3.0, 33.4);
            bird2.displayBird();

            Fox fox1 = new Fox();
            fox1.name = "Alex";
            fox1.region = "North America";
            fox1.age = 5.5;
            fox1.weight = 6.3;
            fox1.displayFox();

            Fox fox2 = new Fox("Max", "Arctic", 3.7, 4.2);
            fox2.displayFox();
        }
    }
}
