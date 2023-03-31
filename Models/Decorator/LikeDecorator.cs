namespace DesignPatterns_SocialMedia.Models
{
    public class LikeDecorator
    {
        public int Like;  
        public LikeDecorator() 
        {
            Like = 1;
        }

        public int getLike()
        {
            return Like;
        }
    }
}
