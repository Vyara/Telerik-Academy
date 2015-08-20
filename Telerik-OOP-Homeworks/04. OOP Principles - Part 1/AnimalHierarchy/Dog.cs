namespace AnimalHierarchy
{
    using System;


    public class Dog : Animal
    {
        //fields

        //constructors
        public Dog(string name, int age, string sex)
            :base(name, age, sex)
        {

        }
        //properties

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Wof!");
        }
    }
}
