namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Interfaces;
    using EventScheduler.Data.Enumerations;
    [Serializable]
    public class Participant : Person, IParticipant, IDriver
    {
        private static int participantCount = 0;

        private bool hasPaid = false;
        private string gsm;
        private Event eventToAttend;
        private string meetPoint;
        private decimal moneyPaid;
        private string email;
        private int seatsAvailable;
        private bool isDriver;

        public Participant()
        { }

        public Participant(string firstName, string lastName, Gender gender, string email, string gsm, decimal moneyPaid, int age, bool isDriver=false)
            : base(firstName, lastName, age,gender)
        {
            this.ParticipantGender = gender;
            this.EMail = email;
            this.GSM = gsm;
            this.MoneyPaid = moneyPaid;
            this.IsDriver = isDriver;

        }
        public Gender ParticipantGender { get; private set; }

        public bool IsParticipant
        {
            get;
            private set;
        }

        public bool IsDriver
        {
            get { return this.isDriver; }
            set { this.isDriver = value; }
        }

        public Event EventToOrganize
        {
            get
            {
                return this.eventToAttend;
            }
            private set
            {
                this.eventToAttend = value;
            }
        }
        public int SeatsAvailable
        {
            get
            {
                return this.seatsAvailable;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Seats available must be greater than 0.");
                }
                this.seatsAvailable = value;
            }
        }
        public string MeetPoint
        {
            get {return this.meetPoint;}
            set
            {
                this.meetPoint = value;
            }
        }
        public bool HasPaid
        {
            get
            {
                return this.hasPaid;
            }
            private set
            {
                this.hasPaid = value;
            }
        }
        public string GSM
        {
            get
            {
                return this.gsm;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 6)
                {
                    throw new Exception("Length of GSM number must be at least 8 symbols.");
                }
                this.gsm = value;
            }
        }
        public decimal MoneyPaid
        {
            get
            {
                return this.moneyPaid;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money paid must be greater than 0.");
                }
                this.moneyPaid = value;
            }
        }
        public string EMail
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 || !value.Contains('@'))
                {
                    throw new Exception("Invalid e-mail.");
                }

                this.email = value;
            }
        }

        public void PayForAttendance(Participant participant, decimal moneyPaid)
        {
            if (moneyPaid < EventToOrganize.Budget / participantCount)
            {
                participant.HasPaid = true;
            }
            else
            {
                participant.HasPaid = false;
                Console.WriteLine("Money paid not enough.");
            }
        }


        public void AddMusicalWish(string wish)
        {
            StreamWriter sw = new StreamWriter("..\\..\\MusicalWishList.txt");
            using (sw)
            {
                sw.WriteLine(wish);
            }
        }

    }
}
