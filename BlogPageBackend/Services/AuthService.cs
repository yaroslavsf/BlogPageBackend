using BlogPageBackend.Data.Entities;
using BlogPageBackend.Data.Repositories;
using BlogPageBackend.Models;

namespace BlogPageBackend.Services
{
    public class AuthService
    {
        private readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /*public void AddUser(UserModel user)
        {
            var new_user = new User();
            new_user.UserName = 
            commentRepository.InsertComment(comment);
        }*/
    }
}
