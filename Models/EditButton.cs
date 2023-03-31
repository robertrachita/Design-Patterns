namespace DesignPatterns_SocialMedia.Models
{
    public class EditButton : Button
    {
        public override void Click()
        {
            NotifySubscribers();
        }
    }
}
