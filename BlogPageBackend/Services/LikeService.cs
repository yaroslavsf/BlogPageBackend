using BlogPageBackend.Data.Entities;
using BlogPageBackend.Data.Repositories;

namespace BlogPageBackend.Services
{
    public class LikeService : ILikeService
    {
        public readonly ILikeRepository likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            this.likeRepository = likeRepository;
        }

        public List<Like> GetLikesByPostId(int postId)
        {
            return likeRepository.GetLikesByPostId(postId);
        }

        public void AddLikeWithPostIdAndAuthorId(int postId, int authorId, Like like)
        {
            like.AuthorId = authorId;
            like.PostId = postId;
            likeRepository.InsertLike(like);
        }
    }
}
