namespace DesignPatterns_SocialMedia.Models
{
    public static class CreatedPosts
    {
        private static List<Post> posts = new List<Post>();
        private static int id = 5;
        
        static CreatedPosts()
        {
            posts.Add(CreateTextPost(1, "This is the content", "This is the title"));
            posts.Add(CreateTextPost(2, "This is the content again", "Text Post"));
            posts.Add(CreateImagePost(3, "https://i.redd.it/5gnz9r0fcaqa1.jpg", "Image Post"));
            posts.Add(CreateVideoPost(4, "https://vimeo.com/810735707", "Video Post"));
        }

        public static void IncreaseID()
        {
            id++;
        }
        public static int GetID()
        {
            return id;
        }
        public static List<Post> GetPosts()
        {
            return posts;
        }
        public static void AddPost(Post post)
        {
            posts.Add(post);
            id++;
        }
        public static Post CreateTextPost(int id, String content, String title)
        {
            return new TextPost(id, content, title);
        }

        public static Post CreateImagePost(int id, String content, String title)
        {
            return new ImagePost(id, content, title);
        }

        public static Post CreateVideoPost(int id, String content, String title)
        {
            return new VideoPost(id, content, title);
        }
    }
}
