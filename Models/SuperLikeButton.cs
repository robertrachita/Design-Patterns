namespace DesignPatterns_SocialMedia.Models
{
    public class SuperLikeButton : Button
    {
        public override void Click()
        {
            NotifySubscribers();
        }
    }
}
