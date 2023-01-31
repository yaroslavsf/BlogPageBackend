using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogPageBackend.Data;
using BlogPageBackend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BlogPageBackend.Services;

namespace BlogPageBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService service;

        public PostsController(IPostService service)
        {
            this.service = service;
        }

        // GET: api/
        [HttpGet("get_all")]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            return service.GetAllPosts();
        }
        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create_post_by_author/{authorId}")]
        public ActionResult<Post> PostPost(int authorId, Post post)
        {
            service.AddPost(authorId, post);
            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        /*// DELETE: api/Posts/5
        [HttpDelete("delete_post/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Post.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }*/


    }
}
