namespace DesignPatterns_SocialMedia.Models.Factory

{
    public class TextPostCreator : PostCreator
    {
        public override Post CreatePost(string content, string title)
        {
            return new TextPost(content, title);
        }
    }

}
