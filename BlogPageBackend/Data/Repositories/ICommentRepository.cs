using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public interface IUserRepository
    {
        List<Comment> GetAll();
        Comment GetCommentByID(int id);
        List<Comment> GetCommentsByPostId(int postId);
        List<Comment> GetCommentsByUserId(int userId);
        void InsertComment(Comment comment);
    }
}