//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
//All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    class TestAnimalHierarchy
    {
        static void Main()
        {
            //list of Cats
            var cats = new List<Cat>()
            {
                new Cat("Timmy", 2, "male"),
                new Cat("Alex", 0, "male"),
                new Cat("Mr Jones", 3, "male"),
                new Cat("Jessy", 1, "female"),
                new Cat("Sandra", 10, "female")

            };

            //list of Kittens
            var kittens = new List<Kitten>()
            {
                new Kitten("Sunny", 3),
                new Kitten("Sasha", 2),
                new Kitten("Olivia", 3),
                new Kitten("Mary", 1),
                new Kitten("Betty", 5)
            };

            //list of Tomcats
            var tomcats = new List<Tomcat>()
            {
                new Tomcat("Berny", 2),
                new Tomcat("Tom", 7),
                new Tomcat("Ben", 6),
                new Tomcat("Larry", 8),
                new Tomcat("Jimmy", 10)
            };

            //list of Dogs
            var dogs = new List<Dog>()
            {
                new Dog("Rover", 3, "male"),
                new Dog("Tara", 4, "female"),
                new Dog("Charlie", 12, "male"),
                new Dog("Harry", 1, "male"),
                new Dog("Jane", 10, "female")
            };

            //list of Frogs
            var frogs = new List<Frog>()
            {
                new Frog("Kermit", 3, "male"),
                new Frog("Sean", 2, "male"),
                new Frog("Zoe", 8, "female"),
                new Frog("Kelly", 4, "female"),
                new Frog("Ann", 7, "female")
            };

            //calculates avarages
            var catsAverageAge = Animal.AverageAge(cats);
            var kittensAverageAge = Animal.AverageAge(kittens);
            var tomcatsAverageAge = Animal.AverageAge(tomcats);
            var dogsAverageAge = Animal.AverageAge(dogs);
            var frogsAverageAge = Animal.AverageAge(frogs);

            Console.WriteLine("Cats: ");
            Console.WriteLine(new string('-', 30));
            Animal.PrintAnimals(cats);
            Console.WriteLine();
            Console.WriteLine("Cats say: ");
            Console.WriteLine(new string('-', 30));
            cats[0].MakeSound();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Cats average age: {0:F2} years", catsAverageAge);

            Console.WriteLine();
            Console.WriteLine("Kittens: ");
            Console.WriteLine(new string('-', 30));
            Animal.PrintAnimals(kittens);
            Console.WriteLine();
            Console.WriteLine("Kittens say: ");
            Console.WriteLine(new string('-', 30));
            kittens[0].MakeSound();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Kittens average age: {0:F2} years", kittensAverageAge);

            Console.WriteLine();
            Console.WriteLine("Tomcats: ");
            Console.WriteLine(new string('-', 30));
            Animal.PrintAnimals(tomcats);
            Console.WriteLine();
            Console.WriteLine("Tomcats say: ");
            Console.WriteLine(new string('-', 30));
            tomcats[0].MakeSound();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Tomcats average age: {0:F2} years", tomcatsAverageAge);

            Console.WriteLine();
            Console.WriteLine("Dogs: ");
            Console.WriteLine(new string('-', 30));
            Animal.PrintAnimals(dogs);
            Console.WriteLine();
            Console.WriteLine("Dogs say: ");
            Console.WriteLine(new string('-', 30));
            dogs[0].MakeSound();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Dogs average age: {0:F2} years", dogsAverageAge);

            Console.WriteLine();
            Console.WriteLine("Frogs: ");
            Console.WriteLine(new string('-', 30));
            Animal.PrintAnimals(frogs);
            Console.WriteLine();
            Console.WriteLine("Tomcats say: ");
            Console.WriteLine(new string('-', 30));
            frogs[0].MakeSound();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Frogs average age: {0:F2} years", frogsAverageAge);


        }


    }


}
