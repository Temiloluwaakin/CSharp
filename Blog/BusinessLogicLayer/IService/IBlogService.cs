using DomainLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IBlogService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<PostDto>> GetAllBlogPost();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PostDto> GetPostById(int id);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="blogPostDto"></param>
        /// <returns></returns>
        Task CreateBlogPost(PostDto blogPostDto);



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<PostDto>> GetPostsByUser(int id);
    }
}
