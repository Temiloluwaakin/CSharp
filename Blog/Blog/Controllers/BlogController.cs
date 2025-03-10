using BusinessLogicLayer.IService;
using DomainLayer.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
    
        private readonly IBlogService _blogPostService;

        public BlogController(IBlogService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetAllPosts()
        {
            var posts = await _blogPostService.GetAllBlogPost();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPostById(int id)
        {
            var post = await _blogPostService.GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostDto postDto)
        {
            await _blogPostService.CreateBlogPost(postDto);
            return CreatedAtAction(nameof(GetPostById), new { id = postDto.Id }, postDto);
        }
    }
}
