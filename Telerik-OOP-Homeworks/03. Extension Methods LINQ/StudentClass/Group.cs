//Problem 16.* Groups

//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.

namespace StudentClass
{

    public class Group
    {

        //constructors
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        //properties
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }


    }
}
