namespace EventScheduler.Data.Staff
{
    using Interfaces;

    public class Cook : RestaurantStaff, IRequiredStaff
    {        
        public Cook(string name, Event eventToJoin, decimal cost, bool isRequired)
        {
            this.Name = name;
            this.EventToJoin = eventToJoin;
            this.Cost = cost;
            this.IsRequiredStaff = isRequired;
        }

        public override bool IsRequired()
        {
            return base.IsRequiredStaff;
        }

    }
}
