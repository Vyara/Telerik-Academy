namespace SortStudents
{
    using System;

    public class Course : IComparable<Course>, IEquatable<Course>
    {
        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Course other)
        {
            return string.Compare(this.Name, other.Name, true);
        }

        public bool Equals(Course other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Compare(this.Name, other.Name, true) == 0;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Course);
        }

        public override string ToString()
        {
            return string.Format("{0}: ", this.Name);
        }
    }
}
