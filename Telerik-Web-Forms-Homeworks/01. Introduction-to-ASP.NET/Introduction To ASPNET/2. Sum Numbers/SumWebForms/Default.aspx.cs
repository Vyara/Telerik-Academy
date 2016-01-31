namespace SumWebForms
{
    using System;
    using System.Web.UI;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButtonClick(object sender, EventArgs e)
        {
            this.sumResult.Text = (int.Parse(this.sumA.Value) + int.Parse(this.sumB.Value)).ToString();
        }
    }
}