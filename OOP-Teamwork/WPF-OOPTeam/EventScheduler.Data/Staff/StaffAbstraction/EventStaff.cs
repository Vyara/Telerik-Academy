namespace EventScheduler.Data.Staff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    [Serializable]
    public abstract class EventStaff : Person
    {
        protected string Name;
        protected Event EventToJoin;
        protected decimal Cost;
    }
}
