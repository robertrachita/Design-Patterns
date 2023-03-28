namespace DesignPatterns_SocialMedia.Models
{
    public abstract class Post
    {
        protected int Id { get; set; }
        protected String Title { get; set; }
        protected int Likes { get; set; }
        protected List<string> Comments { get; set; }
        protected abstract String Content { get; set; }
        protected DateTime DateOfCreation { get; set; }

        public Post(String content, String title)
        {
            this.Id = new Random().Next(1, 1000000);
            this.Title = title;
            this.Content = content;
            this.DateOfCreation = DateTime.Now;
            this.Likes = 0;
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void Like()
        {
            this.Likes++;
        }

        public abstract String GetContent();
    }
   
}
