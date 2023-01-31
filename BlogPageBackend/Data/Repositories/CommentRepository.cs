using BlogPageBackend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogPageBackend.Data.Repositories
{
    public class CommentRepository : IUserRepository
    {
        private readonly BlogDbContext context;

        public CommentRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public List<Comment> GetAll()
        {
            return context.Comment.ToList();
        }

        public Comment GetCommentByID(int id)
        {
            return context.Comment.Find(id);
        }

        public List<Comment> GetCommentsByUserId(int userId)
        {
            return (List<Comment>)context.Comment.Where(comment => comment.AuthorId.Equals(userId));
        }

        public List<Comment> GetCommentsByPostId(int postId)
        {
            return (List<Comment>)context.Comment.Where(comment => comment.PostId.Equals(postId));
        }

        public void InsertComment(Comment comment)
        {
            context.Comment.Add(comment);
            context.SaveChanges();
        }
    }
}
