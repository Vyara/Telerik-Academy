namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        //fields

        //constructors
        public Cat(string name, int age, string sex)
            :base(name, age, sex)
        {

        }
        //properties

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Mew!");
        }

    }
}
