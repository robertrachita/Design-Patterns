namespace DesignPatterns_SocialMedia.Models
{
    public class CreateButton : Button
    {
        public override void Click()
        {
            NotifySubscribers();
        }
    }
}
