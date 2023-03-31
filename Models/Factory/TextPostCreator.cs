namespace DesignPatterns_SocialMedia.Models.Factory

{
    public class TextPostCreator : PostCreator
    {
        public override Post CreatePost(int id, String content, String title)
        {
            return new TextPost(id, content, title);
        }
    }

}
