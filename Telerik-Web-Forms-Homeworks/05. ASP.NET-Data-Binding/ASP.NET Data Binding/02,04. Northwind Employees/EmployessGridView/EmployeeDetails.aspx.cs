namespace EmployessGridView
{
    using System;
    using System.Web.UI;

    public partial class EmployeeDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LinkButtonRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employees.aspx");
        }
    }
}