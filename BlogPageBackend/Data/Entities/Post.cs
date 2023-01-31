using System.ComponentModel.DataAnnotations;
namespace BlogPageBackend.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
         public int ?AuthorId { get; set; }
        public User Author { get; set; }
        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
