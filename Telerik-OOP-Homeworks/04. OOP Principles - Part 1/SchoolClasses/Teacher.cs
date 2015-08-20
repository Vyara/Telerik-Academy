namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        //fields

        //constructors
        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.Disciplines = new List<Discipline>();

        }

        //properties
        public List<Discipline> Disciplines { get; private set; }

        new public string FirstName
        {
            get
            {
                return base.FirstName;
            }


        }

        new public string LastName
        {
            get
            {
                return base.LastName;
            }

        }
        //methods
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discpline)
        {
            if (!this.Disciplines.Contains(discpline))
            {
                throw new ArgumentException("There is no such discipline.");
            }

            this.Disciplines.Remove(discpline);
        }

        public void AddDisciplines(params Discipline[] disciplines)
        {
            this.Disciplines.AddRange(disciplines);
        }

        public void CLearDisciplines()
        {
            this.Disciplines.Clear();
        }

        public override string ToString()
        {
            var teacher = new StringBuilder();

            var count = 1;
            foreach (var discipline in this.Disciplines)
            {
                teacher.AppendLine(discipline.ToString());
                count++;
            }
            return base.ToString() + teacher;
        }
    }
}
