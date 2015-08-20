namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class Discipline : IComment
    {
        //fields
        private string name;
        private int numberOfExcercises;
        private int numberOfLectures;

        //constructors
        public Discipline(string name, int numberOfExcercises, int numberOfLectures)
        {
            this.Name = name;
            this.NumberOfExcercises = numberOfExcercises;
            this.NumberOfLectures = numberOfLectures;
            this.Comments = new List<string>();
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of excerises cannot be negative.");
                }

                this.numberOfExcercises = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of lectures cannot be negative.");
                }

                this.numberOfLectures = value;
            }
        }

        public List<string> Comments { get; set; }

        //methods
        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            if (!this.Comments.Contains(comment))
            {
                throw new ArgumentException("There is no such comment.");
            }

            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            var discipline = new StringBuilder();

            discipline.AppendLine("Discipline: " + this.Name);
            discipline.AppendLine("Number of exercises: " + this.NumberOfExcercises);
            discipline.AppendLine("Number of lectures: " + this.NumberOfLectures);

            var count = 1;
            foreach (var comment in this.Comments)
            {
                discipline.AppendFormat("Comment {0}: {1}", count, comment);
                discipline.AppendLine();
                count++;
            }

            return discipline.ToString();
        }
    }
}
