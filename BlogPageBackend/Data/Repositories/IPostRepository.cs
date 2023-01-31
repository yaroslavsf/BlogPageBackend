using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        void InsertPost(Post post);
    }
}