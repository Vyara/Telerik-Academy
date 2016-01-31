namespace SimpleChat
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Models;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ChatContext db = new ChatContext();
            this.ChatListView.DataSource = db.Messages.ToList();
            this.ChatListView.DataBind();
            if (this.ViewState["username"] != null)
            {
                ((TextBox)Page.FindControl("tb_Username")).Text = (string)ViewState["username"];
            }

            ((TextBox)Page.FindControl("tb_Message")).Text = string.Empty;
        }

        protected void InsertButton_Command(object sender, CommandEventArgs e)
        {
            var tbUsername = (TextBox)Page.FindControl("tb_Username");
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                return;
            }

            this.ViewState["username"] = tbUsername.Text;

            string username = tbUsername.Text;
            string text = ((TextBox)Page.FindControl("tb_Message")).Text;
            ChatContext db = new ChatContext();
            db.Messages.Add(new Message()
            {
                Username = username,
                Text = text
            });

            db.SaveChanges();
        }

        protected void ChatListView_ItemInserting(object sender, ListViewInsertEventArgs e)
        {
        }
    }
}