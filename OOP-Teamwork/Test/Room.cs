namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Room
    {
        public int Capacity { get; private set; }

        public ICollection<View> Views { get; private set; }

        private ICollection<Person> guests;
        
        public readonly int RoomId;

        public Room(int roomId, int capacity, ICollection<View> views)
        {
            this.RoomId = roomId;
            this.Capacity = capacity;
            this.Views = views;
            this.Guests = new List<Person>();
        }

        public ICollection<Person> Guests {
            get 
            { 
                return new List<Person>(this.guests); 
            }
            private set 
            {
                this.guests = value;
            }
        }

        public void AddGuest(Person guest)
        {
            this.Guests.Add(guest);
        }

        public void RemoveGuest(Person guest)
        {
            this.Guests.Remove(guest);
        }
    }
}
