namespace CookiesExchange
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var cookie = new HttpCookie(new Random().Next().ToString(), "Cookie set by LoginPage.aspx");
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.AppendCookie(cookie);
            Response.Redirect("RedirectPage.aspx");
        }
    }
}