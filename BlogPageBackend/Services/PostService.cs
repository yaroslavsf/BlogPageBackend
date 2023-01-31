using BlogPageBackend.Data.Entities;
using BlogPageBackend.Data.Repositories;

namespace BlogPageBackend.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;
        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }


        public List<Post> GetAllPosts()
        {
            return postRepository.GetAllPosts();
        }

        public void AddPost(int authorId, Post post)
        {
            post.AuthorId = authorId;
            postRepository.InsertPost(post);
        }
    }
}


