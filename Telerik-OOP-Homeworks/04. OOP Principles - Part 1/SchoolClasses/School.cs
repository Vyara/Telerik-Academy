namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        //fields

        //constructors
        public School()
        {
            this.Classes = new List<Class>();
        }

        //properties
        public List<Class> Classes { get; private set; }
        
        //methods
        public void AddClass(Class newClass)
        {
            this.Classes.Add(newClass);
        }

        public void RemoveClass(Class exsistingClass)
        {
            if (!this.Classes.Contains(exsistingClass))
            {
                throw new ArgumentException("There is no such class.");
            }

            this.Classes.Remove(exsistingClass);
        }

        public void AddClasses(params Class[] classes)
        {
            this.Classes.AddRange(classes);
        }

        public override string ToString()
        {
            var school = new StringBuilder();
            
            var count = 1;
            
            foreach (var newClass in this.Classes)
            {
                school.AppendFormat("Class {0}: {1}", count, newClass.TextIdentifier);
                school.AppendLine();
                
                school.AppendLine("Teachers:");

                foreach (var teacher in newClass.SetOfTeachers)
                {
                    school.AppendLine(teacher.FirstName + " " + teacher.LastName);
                }
            }

            return school.ToString();
        }
    }
}
