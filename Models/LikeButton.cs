namespace DesignPatterns_SocialMedia.Models
{
    public class LikeButton : Button
    {
        public override void Click()
        {
            NotifySubscribers();
        }
    }
}
