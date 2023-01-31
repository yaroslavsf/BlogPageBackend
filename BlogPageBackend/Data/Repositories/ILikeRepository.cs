using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public interface ILikeRepository
    {
        List<Like> GetLikesByPostId(int postId);
        void InsertLike(Like like);
    }
}