namespace SimpleChat.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class ChatContext : DbContext
    {
        public ChatContext()
           : base("AjaxChatDb")
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}