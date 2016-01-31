namespace CookiesExchange
{
    using System;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class RedirectPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string item in Request.Cookies)
            {
                this.Literal.Text += Request.Cookies[item].Value + "<br/>";
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var cookie = new HttpCookie(new Random().Next().ToString(), "Cookie set by RedirectPage.aspx");
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.AppendCookie(cookie);
            Response.Redirect("LoginPage.aspx");
        }
    }
}
