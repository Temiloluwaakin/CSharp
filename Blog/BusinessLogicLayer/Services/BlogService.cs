using AutoMapper;
using BusinessLogicLayer.IService;
using DataAccessLayer.IRepository;
using DomainLayer.DTO;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Post> _repository;
        private readonly IMapper _mapper;


        public BlogService(IRepository<Post> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PostDto> GetPostById(int id)
        {
            var post = await _repository.GetByIdAsync(id);
            return _mapper.Map<PostDto>(post);
        }


        public async Task<PostDto>  GetAllBlogPost()
        {
            var posts = await _repository.GetAllAsync();
            return _mapper.Map<PostDto>(posts);
        }


        public async Task CreateBlogPost(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _repository.AddAsync(post);
            await _repository.SaveChangesAsync();
        }

        //Task<PostDto> IBlogService.GetAllBlogPost()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
