namespace Tweets
{
    using System;
    using System.Collections.Generic;

    public class TweetsManager
    {
        public static IEnumerable<Tweet> GetTweets(string username = "Einstein")
        {
            return new List<Tweet>()
            {
                new Tweet() { Date = DateTime.Now.AddDays(-1), Text = "Quit Twitter", User = username },
                new Tweet() { Date = DateTime.Now.AddDays(-5), Text = "Quess I'll go somewhere else then", User = username },
                new Tweet() { Date = DateTime.Now.AddDays(-5.5), Text = "its only 140 symbols, nit enough :(", User = username },
                new Tweet() { Date = DateTime.Now.AddDays(-6), Text = "I could come up with a great theory!", User = username },
                new Tweet() { Date = DateTime.Now.AddDays(-6.5), Text = "Yey, I could write here!", User = username },
                new Tweet() { Date = DateTime.Now.AddDays(-7), Text = "Joined Twitter", User = username }
            };
        }
    }
}