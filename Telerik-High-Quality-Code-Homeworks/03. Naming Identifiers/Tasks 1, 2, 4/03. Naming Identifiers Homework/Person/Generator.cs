namespace PeopleGenerator
{
    public class Generator
    {
        public Person GeneratePerson(int age)
        {
            var newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "John Doe";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Jane Doe";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}