using BlogPageBackend.Data.Entities;

namespace BlogPageBackend.Data.Repositories
{
    public class UserRepository
    {
        private readonly BlogDbContext context;

        public UserRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public List<User> GetAll()
        {
            return context.User.ToList();
        }

        public User GetUserByID(int id)
        {
            return context.User.Find(id);
        }
        public void InsertUser(User user)
        {
            context.User.Add(user);
        }
    }
}
