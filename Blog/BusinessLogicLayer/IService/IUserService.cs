using DomainLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IUserService
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="blogPostDto"></param>
        /// <returns></returns>
        Task CreateUser(UserDto userDto);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserDto> GetUserById(int id);

    }
}
