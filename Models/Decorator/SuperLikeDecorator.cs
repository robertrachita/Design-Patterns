namespace DesignPatterns_SocialMedia.Models
{
    public class SuperLikeDecorator : LikeDecorator
    {
        public SuperLikeDecorator() 
        {
            Like = 2;
        }

    }
}
