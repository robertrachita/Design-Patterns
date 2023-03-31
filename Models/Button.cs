namespace DesignPatterns_SocialMedia.Models
{
    public abstract class Button
    {
        private List<Subscriber> subscribers = new List<Subscriber>();

        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.Update();
            }
        }

        public abstract void Click();
    }
}
