
using System.ComponentModel.DataAnnotations;

namespace BlogPageBackend.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public int ?AuthorId { get; set; }
        public User Author { get; set; }
        public int ?PostId { get; set; }
        public Post Post { get; set; }

    }
}
