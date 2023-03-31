namespace DesignPatterns_SocialMedia.Models
{
    public class CommentButton : Button
    {
        public override void Click()
        {
            NotifySubscribers();
        }
    }
}
