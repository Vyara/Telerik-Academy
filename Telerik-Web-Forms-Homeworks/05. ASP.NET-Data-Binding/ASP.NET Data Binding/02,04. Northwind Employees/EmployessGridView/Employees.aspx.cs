namespace EmployessGridView
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeDetails.aspx?id=" + GridView.SelectedValue);
        }
    }
}