namespace DesignPatterns_SocialMedia
{
    public abstract class Post
    {
        public abstract int Id { get; set; }
        public abstract int likes { get; set; }
        public abstract List<String> comments { get; set; }
        public abstract dynamic content { get; set; }
        public abstract DateOnly dateOfCreation {get; set;}

    }
}
