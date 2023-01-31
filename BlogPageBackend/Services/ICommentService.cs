using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Services
{
    public interface ICommentService
    {
        void AddCommentWithPostIdAndAuthorId(int postId, int authorId, Comment comment);
        List<Comment> GetCommentsByPostId(int postId);
    }
}