namespace DesignPatterns_SocialMedia.Models
{
    public abstract class Post
    {
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected int Likes { get; set; }
        protected List<string> Comments { get; set; }
        protected abstract string Content { get; set; }
        protected DateTime DateOfCreation { get; set; }

        public int GetId()
        {
            return Id;
        }

        public Post(string content, string title)
        {
            Id = new Random().Next(1, 1000000);
            Title = title;
            Content = content;
            DateOfCreation = DateTime.Now;
            Likes = 0;
            Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        public void Like()
        {
            Likes++;
        }

        public abstract string GetContent();
    }

}
