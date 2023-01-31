using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogPageBackend.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //role fk
        public int ?RoleId { get; set; }
        public Role Role { get; set; }
        //
        public List<Like> Likes { get; set; } //likes that user clicked
        //
        public List<Post> Posts { get; set; }
        //
        public List<Comment> Comments { get; set; } //comments left by user

    }
}
