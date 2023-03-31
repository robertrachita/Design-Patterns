using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia
{
    public interface Iterator
    {
        public Boolean hasNext();

        public Boolean isLast();
        public Post next();
    }
}
