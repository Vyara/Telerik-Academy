namespace EventScheduler.Data.Staff
{
    using Interfaces;

    public class Waiter : RestaurantStaff, IRequiredStaff
    {        
        public Waiter(string name, Event eventToJoinn, decimal cost, bool isRequired)
        {
            this.Name = name;
            this.EventToJoin = eventToJoinn;
            this.Cost = cost;
            this.IsRequiredStaff = isRequired;

        }

        public override bool IsRequired()
        {
            return base.IsRequiredStaff;
        }
    }
}
