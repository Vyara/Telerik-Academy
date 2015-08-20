namespace EventScheduler.Data.Staff
{
    using Interfaces;

    public class DJ : AnimationStaff, IRequiredStaff
    {       
        public DJ(string name, Event eventToJoinn, decimal cost)
        {
            this.Name = name;
            this.EventToJoin = eventToJoinn;
            this.Cost = cost;
        }

        public override bool IsRequired()
        {
            return base.IsRequiredStaff;
        }
    }
}
