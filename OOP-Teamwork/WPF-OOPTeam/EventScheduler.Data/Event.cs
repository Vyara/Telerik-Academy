namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using EventScheduler.Data.Staff;
    using EventScheduler.Data.Exceptions;

    [Serializable()]
    public class Event
    {
        public const int EventTitleLenghtMinValue = 2;

        private string title;
        private DateTime dateTime;
        private Location location;
        private Organizer organizer;
        private List<Participant> participantsList;
        private string meetingPoint;
        private decimal budget;
        private List<EventStaff> eventStaff;
        private string comment;


        public Event(string title = "NewEvent")
        {

            string DateTimeString = String.Format("EventCreated{0}{1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

            if (title == "NewEvent")
            {
                this.title = DateTimeString;
            }
            this.comment = string.Concat(this.Comment, DateTimeString);

        }


        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                //if (string.IsNullOrEmpty(value) || value.Length < 2)
                //{
                //    throw new Exception("Event title length must be at least 2 symbols.");
                //}
                Validator.CheckIfNullOrEmpty(value, string.Format(ErrorMessages.NullOrEmpty, "Event title"));
                Validator.CheckIfLengthIsAtLeastNSymbols(value, EventTitleLenghtMinValue, string.Format(ErrorMessages.LengthAtLeast, "Event title", EventTitleLenghtMinValue));


                this.title = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                if (value == default(DateTime))
                {
                    throw new Exception("Date must have value.");
                }

                this.dateTime = value;
            }
        }
        // TODO: Should we leave parameterless constructors of Location/Organizer?
        public Location Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public Organizer Organizer
        {
            get
            {
                return this.organizer;
            }
            set
            {
                this.organizer = value;
            }
        }

        public List<Participant> ParticipantsList
        {
            get
            {
                return this.participantsList;
            }
            set
            {
                this.participantsList = new List<Participant>();
            }
        }

        public string MeetingPoint
        {
            get
            {
                return this.meetingPoint;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Meeting point must be assigned.");
                }
                this.meetingPoint = value;
            }
        }

        public decimal Budget
        {
            get
            {
                return this.budget;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Budget of the event must be assigned.");
                }
                this.budget = value;
            }
        }

        public List<EventStaff> EventStaff
        {
            get
            {
                return this.eventStaff;
            }
            set
            {
                this.eventStaff = new List<EventStaff>();
            }
        }

        public enum Status
        {
            Active, Cancelled, Past
        }

        public string Comment
        {
            get { return this.comment; }
            set
            {
                this.comment = String.Format("{0}\n{1}", this.comment, value);
            }
        }

        public override string ToString()
        {
            return String.Format(@"Event: {0}
                                   Date: {1}
                                   Location: {2}
                                   Organizer: {3}
                                   Meeting point: {4}", this.Title, this.DateTime, this.Location, this.Organizer, this.MeetingPoint);
        }

        public void CarDistribution(Event eventToOrganize)
        {

            var participantsInCars = new Dictionary<string, string>();

           var participantsToDistribute = participantsList.Where(x=>x.IsDriver==false);

            var participantsDrivers = participantsList.Where(x=>x.IsDriver==true);
           
            foreach (var driver in participantsDrivers)
            {
                for (int j = 0; j < participantsToDistribute.Count(); j++)
			        {
			        for (int i = 0; i < driver.SeatsAvailable; i++)
                        {
                            participantsInCars.Add(driver.GSM, participantsToDistribute.ElementAt(j).GSM);
                        }
			        }
            }
        }

    }
}
