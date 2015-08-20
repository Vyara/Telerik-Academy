namespace AnimalHierarchy
{
    using System;


    public class Frog : Animal
    {
        //fields

        //constructors
        public Frog(string name, int age, string sex)
            :base(name, age, sex)
        {

        }
        //properties

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
