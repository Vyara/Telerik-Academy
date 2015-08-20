namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enumerations;

    public abstract class Person
    {
        //dobaveno Andrej 27.03
        public Person(string firstName, string lastName, Gender sex = Gender.NonSpecified)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = sex;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Gender Gender { get; private set; }

        //dobaveno Andrej 27.03 nagore
        public void RoomDistribuition(Participant person, Room room)
        {
            throw new System.NotImplementedException();
        }

        public void CarDistribution(Participant person, Participant driver)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSummary(Event newEvent)
        {
            throw new NotImplementedException();
        }
    }


}
