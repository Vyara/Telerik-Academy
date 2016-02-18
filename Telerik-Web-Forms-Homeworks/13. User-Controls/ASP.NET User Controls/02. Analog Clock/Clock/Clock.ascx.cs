namespace Clock
{
    using System;
    using System.Web.UI;

    public partial class Clock : UserControl
    {
        public string TimeZone
        {
            get { return this.TimeZoneValue.Text; }
            set { this.TimeZoneValue.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}