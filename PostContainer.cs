using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia
{
    public class PostContainer : IterableCollection
    {
        private List<Post> posts { get; set; }

        public PostContainer(List<Post> listOfPosts) {
            posts = listOfPosts;
        }

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

            public Boolean isLast()
            {
                return position == copyOfPosts.Count;
            }

            public Post next()
            {
                if (this.isLast()) return copyOfPosts[position];
                if (this.hasNext()) return copyOfPosts[position++];

                return null;
            }
        }
    }
}
