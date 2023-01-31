using Microsoft.AspNetCore.Mvc;
using BlogPageBackend.Data;
using BlogPageBackend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BlogPageBackend.Services;

namespace BlogPageBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService service;
        public CommentsController(ICommentService service)
        {
            this.service = service;
        }

        // GET: api/Comments/5
        [HttpGet("comments_of_post/{id}")]
        public ActionResult<IEnumerable<Comment>> GetCommentsByPostId(int id)
        {
            var comments = service.GetCommentsByPostId(id);
            return comments;
        }

        // POST: api/Test
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create_comment_of_post/{postId}/by_user/{userId}")]
        public ActionResult<Comment> PostComment(int postId, int userId, Comment comment)
        {
            service.AddCommentWithPostIdAndAuthorId(postId, userId, comment);
            return CreatedAtAction("GetPost", new { id = comment.Id }, comment);
        }



        // DELETE: api/Comments/5
        /*[HttpDelete("delete_comment/{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comment.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();

            return NoContent();
        }*/

        /* private bool CommentExists(int id)
         {
             return _context.Comment.Any(e => e.Id == id);
         }*/
    }
}
