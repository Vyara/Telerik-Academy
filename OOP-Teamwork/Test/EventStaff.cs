namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enumerations;

    //dobaveno Andrej 27.03
    public class EventStaff : Person
    {
        public EventStaff(string firstName, string lastName, Gender sex = Gender.NonSpecified, EventStaffType type = EventStaffType.Other)
            : base(firstName, lastName, sex)
        {
            this.Type = type;
        }

        public EventStaffType Type { get; private set; }
    }
}
