using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext context;

        public PostRepository(BlogDbContext context)
        {
            this.context = context;
        }
        public List<Post> GetAllPosts()
        {
            if (context.Post!= null)
                return context.Post.ToList();
            else return null;
        }

        public void InsertPost(Post post)
        {
            context.Post.Add(post);
            context.SaveChanges();
        }

    }
}
