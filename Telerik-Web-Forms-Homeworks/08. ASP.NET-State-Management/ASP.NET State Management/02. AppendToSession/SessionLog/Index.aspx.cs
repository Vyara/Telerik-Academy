namespace SessionLog
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["values"] == null)
            {
                this.Session.Add("values", new List<string>());
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var list = (List<string>)Session["values"];
            list.Add(this.TextBox.Text);
            this.Label.Text = string.Empty;
            foreach (var item in list)
            {
                this.Label.Text += "<br/>" + item;
            }

            this.TextBox.Text = string.Empty;
        }
    }
}