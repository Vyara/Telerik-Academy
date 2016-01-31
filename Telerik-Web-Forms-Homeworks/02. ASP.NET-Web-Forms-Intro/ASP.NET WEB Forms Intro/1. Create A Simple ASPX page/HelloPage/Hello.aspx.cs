namespace HelloPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;


    public partial class Hello : System.Web.UI.Page
    {
        protected void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Name.Text) || this.Name.Text.Length < 2)
            {
                this.Result.Text = "Anonimous";
            }
            else
            {
                this.Result.Text = this.Name.Text;
            }
        }
    }
}