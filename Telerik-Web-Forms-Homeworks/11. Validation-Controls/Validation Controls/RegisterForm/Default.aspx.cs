namespace RegisterForm
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Default : Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (this.IsPostBack && Page.IsValid)
            {
                this.LabelMessage.Text = "Page is valid!";
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                this.LabelMessage.Text = "The page is valid!";
            }

            this.LabelMessage.Visible = Page.IsValid;
        }

        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = this.RequiredTickValidator.Checked;
        }
    }
}