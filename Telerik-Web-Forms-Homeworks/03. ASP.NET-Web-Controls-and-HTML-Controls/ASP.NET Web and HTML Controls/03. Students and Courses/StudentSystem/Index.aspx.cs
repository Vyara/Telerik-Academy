namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.WebControls;

    public partial class Index : System.Web.UI.Page
    {
        public IQueryable<string> GetUniversities()
        {
            return (new[] { "MIT", "Cambridge", "Stanford", "Oxford", "Berkeley" }).AsQueryable();
        }

        public IQueryable<string> GetSpecialities()
        {
            return (new[] { "Mathematics", "Computer Science", "Physics", "Engineering", "Art" }).AsQueryable();
        }

        public IQueryable<string> GetCourses()
        {
            return (new[] { "Classic English Literature", "Data Strictures and Algorithms", "Classical Mecahnics", "Linear Algebra", "Aerodynamics" }).AsQueryable();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            this.Name.Text = this.FirstName.Text + " " + this.LastName.Text;
            this.Number.Text = "Faculty number: " + this.FacultyNumber.Text;
            this.UniSpec.Text = "University: " + this.University.SelectedValue + " | Speciality: " + this.Speciality.SelectedValue;

            var selectedCourses = new List<string>();

            foreach (ListItem item in this.Courses.Items)
            {
                if (item.Selected)
                {
                    selectedCourses.Add(item.Value);
                }
            }

            this.SelectedCourses.Text = "Courses: " + string.Join(", ", selectedCourses);
            this.ResultDiv.Visible = true;
        }
    }
}