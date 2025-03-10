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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;


        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<UserDto> GetUserById(int id)
        {
            var user = await ((IUserRepository)_repository).GetUserWithPostAsync(id); // Use the correct method
            return _mapper.Map<UserDto>(user);
        }

        
        public async Task CreateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.Post = new List<Post>();
            await _repository.AddAsync(user);
            await _repository.SaveChangesAsync();
        }
    }
}
