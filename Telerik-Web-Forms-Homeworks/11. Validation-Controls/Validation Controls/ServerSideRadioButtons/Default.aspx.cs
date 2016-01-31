namespace ServerSideRadioButtons
{
    using System;
    using System.Web.UI;

    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Radios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Radios.SelectedIndex == 0)
            {
                this.MaleOptions.Visible = true;
                this.FemaleOptions.Visible = false;
            }
            else
            {
                this.MaleOptions.Visible = false;
                this.FemaleOptions.Visible = true;
            }
        }
    }
}