using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; private set; }

        public void UpVote()
        {
            Rating++;
        }

        public void DownVote()
        {
            Rating--;
        }
    }
}
