namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enumerations;

    public class Organizer : Participant, IParticipant
    {

        public Organizer(string firstName, string lastName, Gender sex = Gender.NonSpecified)
            : base(firstName, lastName, sex)
        {
        }

        public void AddParticipant(Participant participant, Event @event)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteParticipant(Participant participant, Event @event)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}
