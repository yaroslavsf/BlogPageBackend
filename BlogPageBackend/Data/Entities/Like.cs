using System.ComponentModel.DataAnnotations;

namespace BlogPageBackend.Data.Entities
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public int ?PostId { get; set; }
        public Post Post { get; set; }
        public int ?AuthorId { get; set; }
        public User Author { get; set; }
    }
}
