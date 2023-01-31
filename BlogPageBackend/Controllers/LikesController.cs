using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogPageBackend.Data;
using BlogPageBackend.Data.Entities;
using BlogPageBackend.Data.Repositories;
using BlogPageBackend.Services;

namespace BlogPageBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly ILikeService service;

        public LikesController(ILikeService service)
        {
            this.service = service;
        }


        // GET: api/Likes/5
        [HttpGet("likes_of_post/{id}")]
        public ActionResult<List<Like>> GetLikesByPost(int id)
        {
            var likes = service.GetLikesByPostId(id);
            return likes;
        }


        // PUT: api/Likes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create_like_under_post/{postId}/by_user/{userId}")]
        public ActionResult<Like> PostLike(int postId, int userId, Like like)
        {
            service.AddLikeWithPostIdAndAuthorId(postId, userId, like);
            return CreatedAtAction("GetLike", new { id = like.Id }, like);
        }

        // DELETE: api/Likes/5
        /*[HttpDelete("delete_like_under_post/{id}")]
        public async Task<IActionResult> DeleteLike(int id)
        {
            var like = await _context.Like.FindAsync(id);
            if (like == null)
            {
                return NotFound();
            }

            _context.Like.Remove(like);
            await _context.SaveChangesAsync();

            return NoContent();
        }*/
    }
}
