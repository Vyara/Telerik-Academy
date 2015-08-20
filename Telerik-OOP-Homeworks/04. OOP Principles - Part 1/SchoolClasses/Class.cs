namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Class : IComment
    {
        //fields

        //constructors
        public Class(string textIdentifier, params Teacher[] setOfTeachers)
        {
            this.TextIdentifier = textIdentifier;
            this.SetOfTeachers = new List<Teacher>();
            this.SetOfTeachers.AddRange(setOfTeachers);
        }

        //properties
        public string TextIdentifier { get; private set; }

        public List<Teacher> SetOfTeachers { get; private set; }

        public List<string> Comments { get; private set; }

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
            var classes = new StringBuilder();
            classes.AppendLine("Class: " + this.TextIdentifier);

            var count = 1;
            foreach (var teacher in SetOfTeachers)
            {
                classes.AppendFormat("Teacher {0}: {1} {2}", count, teacher.FirstName, teacher.LastName);
            }

            return classes.ToString();
        }
    }
}
