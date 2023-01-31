using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly BlogDbContext context;

        public LikeRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public List<Like> GetLikesByPostId(int postId)
        {
            return (List<Like>)context.Like.Where(like => like.PostId.Equals(postId));
        }
        public void InsertLike(Like like)
        {
            context.Like.Add(like);
            context.SaveChanges();
        }
    }
}
