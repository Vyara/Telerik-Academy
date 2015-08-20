namespace EventScheduler.Data.Staff
{
    using Interfaces;

    public abstract class RestaurantStaff : EventStaff, IRequiredStaff
    {
        protected bool IsRequiredStaff = false;

        public virtual bool IsRequired()
        {
            return IsRequiredStaff;
        }
    }
}
