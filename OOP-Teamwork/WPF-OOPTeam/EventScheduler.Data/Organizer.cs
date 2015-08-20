namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    using Enumerations;
    [Serializable]
    public class Organizer : Participant, IParticipant
    {
        
        public Organizer()
        { }

        public Organizer (string firstName, string lastName, Gender gender, string email, string gsm, decimal moneyPaid, int age) 
            : base (firstName, lastName,gender, email, gsm, moneyPaid, age)
        {

        }
        
        public void AddParticipant(List<Participant> participantList, Participant newParticipant)
        {
            participantList.Add(newParticipant);
        }

        public void DeleteParticipant(List<Participant> participantList, Participant participantToDelete)
        {
            participantList.Remove(participantToDelete);
        }

        public void ChangeStatus(Event organizedEvent)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
