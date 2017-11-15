using System;
namespace RedditApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Score { get; set; }
    }
}
