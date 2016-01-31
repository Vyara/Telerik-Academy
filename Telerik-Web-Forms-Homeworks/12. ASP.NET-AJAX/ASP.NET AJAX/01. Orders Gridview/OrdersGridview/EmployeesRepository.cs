namespace _01.AjaxUpdate
{
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeesRepository
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<Employee> SelectEmployees()
        {
            var found = db.Employees.ToList();

            foreach (var item in found)
            {
                item.Notes = item.Notes.Substring(0, 20) + " ...";
            }

            return found;
        }
    }
}