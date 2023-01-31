using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public class CommentRepository
    {
        private readonly BlogDbContext context;

        public CommentRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public List<Comment> GetAll()
        {
            return context.Comments.ToList();
        }

        public Comment GetCommentByID(int id)
        {
            return context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByUserId(int userId)
        {
            return (List<Comment>)context.Comments.Where(comment => comment.AuthorId.Equals(userId));
        }

        public List<Comment> GetCommentsByPostId(int postId)
        {
            return (List<Comment>)context.Comments.Where(comment => comment.PostId.Equals(postId));
        }

        public void InsertComment(Comment comment)
        {
            context.Comments.Add(comment);
        }
    }
}
