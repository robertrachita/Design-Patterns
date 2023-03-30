namespace DesignPatterns_SocialMedia.Models
{
    public abstract class Post
    {
        protected int Id { get; set; }
        protected String Title { get; set; }
        protected int Likes { get; set; }
        protected List<String> Comments { get; set; }
        protected abstract String Content { get; set; }
        protected DateTime DateOfCreation { get; set; }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public String GetTitle()
        {
            return Title;
        }
        public void SetTitle(String title)
        {
            Title = title;
        }
        public int GetLikes()
        {
            return Likes;
        }
        public List<String> GetComments()
        {
            return Comments;
        }
        public DateTime GetDateOfCreation()
        {
            return DateOfCreation;
        }
        

        public Post(int id, String content, String title)
        {
            Id = id;
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

        public void AddLike()
        {
            Likes++;
        }

        public abstract string GetContent();
    }

}
