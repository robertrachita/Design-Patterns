using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia
{
    public class PostContainer : IterableCollection
    {
        private List<Post> posts { get; set; }

        public Iterator createIterator()
        {
            if (posts == null) return null;

            PostIterator postIterator = new PostIterator(posts);
            return postIterator;
        }

        public void addPost(Post postToAdd)
        {
            posts.Add(postToAdd);
        }

        private class PostIterator : Iterator
        {
            private int position { get; set; }

            private List<Post> copyOfPosts { get; } 

            public PostIterator(List<Post> posts)
            {
                this.copyOfPosts = posts;
            }

            public Boolean hasNext()
            {
                return position < copyOfPosts.Count;       
            }

            public Object next()
            {
                if (this.hasNext()) return copyOfPosts[position++];

                return null;
            }
        }
    }
}
