namespace DesignPatterns_SocialMedia.Models
{
    public class DislikeDecorator : LikeDecorator
    {
        public DislikeDecorator() 
        {
            Like = -1;
        }
    }
}
