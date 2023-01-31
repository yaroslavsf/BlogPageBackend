using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Services
{
    public interface ILikeService
    {
        void AddLikeWithPostIdAndAuthorId(int postId, int authorId, Like like);
        List<Like> GetLikesByPostId(int postId);
    }
}