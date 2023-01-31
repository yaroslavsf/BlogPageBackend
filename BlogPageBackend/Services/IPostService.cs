using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Services
{
    public interface IPostService
    {
        void AddPost(int authorId, Post post);
        List<Post> GetAllPosts();
    }
}