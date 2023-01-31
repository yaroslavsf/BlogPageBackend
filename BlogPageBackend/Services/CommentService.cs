using BlogPageBackend.Data.Entities;
using BlogPageBackend.Data.Repositories;
using Microsoft.Identity.Client;

namespace BlogPageBackend.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUserRepository commentRepository;

        public CommentService(IUserRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public List<Comment> GetCommentsByPostId(int postId)
        {
            return commentRepository.GetCommentsByPostId(postId);


        }
        public void AddCommentWithPostIdAndAuthorId(int postId, int authorId, Comment comment)
        {
            comment.AuthorId = authorId;
            comment.PostId = postId;
            commentRepository.InsertComment(comment);
        }
    }
}
