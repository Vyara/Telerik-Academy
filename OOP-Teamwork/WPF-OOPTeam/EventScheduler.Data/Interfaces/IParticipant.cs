namespace EventScheduler.Data.Interfaces
{
    public interface IParticipant
    {
        bool IsParticipant { get; }

        Event EventToOrganize { get; }

        void PayForAttendance(Participant participant, decimal moneyPaid);
    }
}
